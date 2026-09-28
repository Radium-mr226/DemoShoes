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
        
        private void OrderForm_Load(object sender, EventArgs e)
        {
            MainForm mainForm = this.Owner as MainForm;
            var ordList = mainForm._orderList;
            foreach (var prod in ordList)
            {
                var pr = new ProductUserControl(prod, false);
                flowLayoutPanel1.Controls.Add(pr);
                
            }
            RecalculateTotal();
        }

        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            MainForm mainForm = this.Owner as MainForm;
            Program.context.Orders.Add(mainForm._order);
            foreach (var prod in mainForm._orderList)
            {
                Program.context.Order_Items.Add(prod);
                Product_Stock product_Stock = Program.context.Product_Stock.FirstOrDefault(p=> p.Id_Product == prod.Id_Product && p.Size == prod.Size);
                product_Stock.Quantity -= (int)prod.Quantity;
            }
            Program.context.SaveChanges();
            
        }

        public void RemoveOrderItem(Order_Items item, ProductUserControl control)
        {
            MainForm mainForm = this.Owner as MainForm;

            mainForm._orderList.Remove(item);       // убираем из списка заказа
            flowLayoutPanel1.Controls.Remove(control); // убираем сам контрол с формы
            control.Dispose();                       // освобождаем ресурсы контрола

            mainForm.RefreshProdList();
        }

        private void OnPriceChanged()
        {

            TotalPriceLabel.Text = "Итого: " + _price.ToString("N2");
            // здесь можно делать что угодно ещё: блокировать кнопку при нулевой сумме и т.д.
            CreateOrderButton.Enabled = _price > 0;
        }

        public void RecalculateTotal()
        {
            MainForm mainForm = this.Owner as MainForm;
            Price = mainForm._orderList.Sum(o => o.Unit_Price * o.Quantity);
        }
    }
}
