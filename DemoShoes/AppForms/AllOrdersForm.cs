using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DemoShoes.CustomUserControl;
using DemoShoes.Models;

namespace DemoShoes.AppForms
{
    public partial class AllOrdersForm : Form
    {
        private Users _user;
        public AllOrdersForm(Users users)
        {
            InitializeComponent();
            _user = users;
        }

        private void AllOrdersForm_Load(object sender, EventArgs e)
        {
            fillOrderList();
            

        }

        private void fillOrderList()
        {
            var ordersList = Program.context.Orders.ToList();
            foreach (var order in ordersList)
            {
                flowLayoutPanel1.Controls.Add(new OrderUserControl(order, _user));
            }
        }
    }
}
