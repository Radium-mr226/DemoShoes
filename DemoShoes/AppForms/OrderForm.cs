using DemoShoes.CustomUserControl;
using DemoShoes.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoShoes.AppForms
{
    public partial class OrderForm : Form
    {
        private bool _isNew;      // true — оформление нового заказа из корзины
        private bool _canEdit;    // false — только просмотр
        private List<Order_Items> _items;
        private Orders _order;
        private Users _user;
        public decimal _price;
        public decimal Price
        {
            get { return _price; }
            set
            {
                _price = value;
                OnPriceChanged();   // вызывается при каждом изменении
            }
        }
        public OrderForm(Users users)
        {
            InitializeComponent();
            _user = users;
        }

        public OrderForm(Orders order, List<Order_Items> items, bool isNew, bool canEdit, Users users)
        {
            InitializeComponent();
            _order = order;
            _items = items;
            _isNew = isNew;
            _canEdit = canEdit;
            _user = users;
            //this.TitleLabel.Text = 
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            foreach (var prod in _items)
            {
                var pr = new ProductUserControl(prod, false, _isNew, _user);
                flowLayoutPanel1.Controls.Add(pr);
            }
            RecalculateTotal();

            var users = Program.context.Users
                .ToList() // сначала забираем из БД, потом склеиваем строку в памяти
                .Select(u => new
                {
                    u.Id_User,
                    FullName = (u.Last_Name + " " + u.First_Name + " " + u.Middle_Name).Trim()
                })
                .ToList();

            UserComboBox.DisplayMember = "FullName";
            UserComboBox.ValueMember = "Id_User";
            UserComboBox.DataSource = users;
            UserComboBox.SelectedValue = _order.Id_User; // показываем, кому принадлежит заказ
            UserComboBox.Enabled = _canEdit;

            CreateOrderButton.Text = _isNew ? "Оформить заказ" : "Сохранить изменения";
            CreateOrderButton.Visible = _canEdit;
            CreateOrderButton.Enabled = _items.Count > 0;
        }

        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            if (_isNew)
            {
                DialogResult isSave = MessageBox.Show("Вы уверены, что хотите схоранить?", "Информация", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (isSave == DialogResult.Yes)
                {
                    MainForm mainForm = this.Owner as MainForm;
                    Program.context.Orders.Add(mainForm._order);
                    if (_user.Id_Role == 1)
                        mainForm._order.Id_User = (int)UserComboBox.SelectedValue;
                    foreach (var prod in mainForm._orderList)
                    {
                        Program.context.Order_Items.Add(prod);
                        Product_Stock product_Stock = Program.context.Product_Stock.FirstOrDefault(p => p.Id_Product == prod.Id_Product && p.Size == prod.Size);
                        product_Stock.Quantity -= (int)prod.Quantity;
                        splitContainer1.Panel2.Controls[0].Controls.Clear();
                        Price = 0;
                    }
                    Program.context.SaveChanges();
                    mainForm._order = new Orders();
                    mainForm._orderList.Clear();
                    mainForm.RefreshProdList();
                }
                return;
            }
            try
            {
                _order.Id_User = (int)UserComboBox.SelectedValue; // если разрешено менять заказчика
                Program.context.SaveChanges();
                MessageBox.Show("Изменения сохранены");
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось сохранить: " + ex.Message);
            }

        }

        public void RemoveOrderItem(Order_Items item, ProductUserControl control)
        {
            if (!_canEdit) return;

            _items.Remove(item);
            if (!_isNew)
                Program.context.Order_Items.Remove(item); // для сохранённого заказа удалится при SaveChanges

            flowLayoutPanel1.Controls.Remove(control);
            control.Dispose();
            RecalculateTotal();
            CreateOrderButton.Enabled = _items.Count > 0;
        }

        private void OnPriceChanged()
        {

            TotalPriceLabel.Text = "Итого: " + _price.ToString("N2");
            // здесь можно делать что угодно ещё: блокировать кнопку при нулевой сумме и т.д.
            CreateOrderButton.Enabled = _price > 0;
        }

        public void RecalculateTotal()
        {
            Price = _items.Sum(o => o.Unit_Price * o.Quantity);

        }

        private void OrderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_isNew || DialogResult == DialogResult.OK) return;

            foreach (var entry in Program.context.ChangeTracker.Entries().ToList())
            {
                if (entry.State != System.Data.Entity.EntityState.Detached)
                    entry.Reload();
            }
        }
    }
}
