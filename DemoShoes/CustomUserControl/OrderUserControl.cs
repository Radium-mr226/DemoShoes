using DemoShoes.AppForms;
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

namespace DemoShoes.CustomUserControl
{
    public partial class OrderUserControl : UserControl
    {
        private Orders _orders;
        private Users _user;
        public OrderUserControl(Orders orders, Users users)
        {
            InitializeComponent();
            _orders = orders;
            _user = users;
        }

        private void OrderUserControl_Load(object sender, EventArgs e)
        {
            orderIdLabel.Text = "Заказ № " + _orders.Id_Order.ToString();
            sumOrderLabel.Text = "Сумма заказа = " + Program.context.Order_Items.Where(p => p.Orders.Id_Order == _orders.Id_Order).Sum(o=> (o.Unit_Price*o.Quantity)).ToString();
            var user = Program.context.Users.FirstOrDefault(p => p.Id_User == _orders.Id_User);
            userLabel.Text = "Заказал(а) " + user.First_Name + " " + user.Last_Name + " " + user.Middle_Name;
            quantityProdLabel.Text = "Количество позиций " + Program.context.Order_Items.Where(p => p.Id_Order == _orders.Id_Order).Count().ToString();
        }

        private void orderIdLabel_Click(object sender, EventArgs e)
        {
            var items = Program.context.Order_Items
                .Where(i => i.Id_Order == _orders.Id_Order)
                .ToList();

            bool isAdmin = _user.Id_Role == 1; // подставьте id роли администратора
            new OrderForm(_orders, items, isNew: false, canEdit: isAdmin, _user).ShowDialog();
        }
    }
}
