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
            
        public OrderForm()
        {
            InitializeComponent();
        }
        
        private void OrderForm_Load(object sender, EventArgs e)
        {
            MainForm mainForm = this.Owner as MainForm;
            var ordList = mainForm._order;
            foreach (var prod in ordList)
            {
                var pr = new ProductUserControl(prod, false);
                flowLayoutPanel1.Controls.Add(pr);
            }

        }
    }
}
