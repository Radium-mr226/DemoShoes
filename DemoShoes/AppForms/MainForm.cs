using DemoShoes.CustomUserControl;
using DemoShoes.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoShoes
{
    public partial class MainForm : Form
    {

        private Users _user;
        private List<Products> _products = Program.context.Products.ToList();

        public MainForm()
        {
            InitializeComponent();
            _user = null;
            FillProductsList(_products);
            //this.splitContainer1.SplitterDistance = 120;
            //this.SearchTextBox.Visible = false;
            //this.CategoryComboBox.Visible = false;
            //this.SortComboBox.Visible = false;
        }

        public MainForm( Users user)
        {
            InitializeComponent();
            _user = user;
            FillProductsList(_products);
        }

        private void FillProductsList(List<Products> products)
        {
            foreach (var prod in products)
            {
                var pr = new ProductUserControl(prod);
                flowLayoutPanel1.Controls.Add(pr);
            }
        }

        public void RefreshProdList()
        {
            splitContainer1.Panel2.Controls[0].Controls.Clear();
            FillProductsList(_products);
        }

        public void ClearList()
        {
            splitContainer1.Panel2.Controls[0].Controls.Clear();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var categories = Program.context.Categories
                .OrderBy(c => c.Category_Name)
                .ToList();

            categories.Insert(0, new Categories { Id_Category = 0, Category_Name = "Все категории" });

            CategoryComboBox.DisplayMember = "Category_Name";
            CategoryComboBox.ValueMember = "Id_Category";
            CategoryComboBox.DataSource = categories;
            CategoryComboBox.SelectedIndex = 0;


            this.SortComboBox.SelectedIndex = 0;
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {

            FilterFun();
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {


            FilterFun();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            SortComboBox.SelectedIndex = 0;
            CategoryComboBox.SelectedIndex = 0;
            SearchTextBox.Text = "";
        }

        private void FilterFun()
        {
            //фильтрация
            List<Products> tData = _products;
            if (CategoryComboBox.SelectedIndex != 0)
            {
                tData = tData.Where(p => p.Id_Category == (int)CategoryComboBox.SelectedValue).ToList();
            }
            //поиск
            tData = tData.Where(p => p.Product_Name.ToLower().Contains(SearchTextBox.Text.ToLower())).ToList();
            //сортировка
            if (SortComboBox.SelectedIndex == 1)
            {
                tData = tData.OrderBy(p => p.Price).ToList();
            }
            else if(CategoryComboBox.SelectedIndex == 2)
            {
                tData = tData.OrderByDescending(p => p.Price).ToList();
            }

            ClearList();
            FillProductsList(tData);
        }

        private void SortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterFun();
        }
    }
}
