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

namespace DemoShoes
{
    public partial class MainForm : Form
    {

        private Users _user;
        public MainForm()
        {
            InitializeComponent();
            _user = null;
            FillProductsList();
        }

        public MainForm( Users user)
        {
            InitializeComponent();
            _user = user;
            FillProductsList();
        }

        private void FillProductsList()
        {
            List<Products> products = Program.context.Products.ToList();
            foreach (var prod in products)
            {
                var pr = new ProductUserControl(prod);
                flowLayoutPanel1.Controls.Add(pr);
            }
        }

        public void RefreshProdList()
        {
            splitContainer1.Panel2.Controls[0].Controls.Clear();
            FillProductsList();
        }
    }
}
