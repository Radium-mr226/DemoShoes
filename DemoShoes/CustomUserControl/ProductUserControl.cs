using DemoShoes.AppForms;
using DemoShoes.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoShoes.CustomUserControl
{
    public partial class ProductUserControl : UserControl
    {
        private Products _products;
        public ProductUserControl(Products products)
        {
            InitializeComponent();
            _products = products;
            FillFields();
        }

        private void FillFields()
        {
            string dir = Path.GetFullPath(Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory, @"..\..\Resources\Images"));
            string path = Path.Combine(dir, _products.Image ?? "");

            if (!string.IsNullOrEmpty(_products.Image) && File.Exists(path))
            {
                using (var img = Image.FromFile(path))
                ProductPictureBox.Image = new Bitmap(img); // копия, чтобы файл не оставался заблокированным
            }
            else
            {
                ProductPictureBox.Image = null; // заглушка из ресурсов
                MessageBox.Show(path + "\nСуществует: " + File.Exists(path));

            }

            FactoryNameLabel.Text = _products.Factories.Id_Factory.ToString() + " | " + _products.Product_Name.ToString();
            CategotyLabel.Text += _products.Categories.Category_Name.ToString();
            QuantityLabel.Text += Program.context.Product_Stock.FirstOrDefault(p => p.Id_Product == _products.Id_Product).Quantity.ToString();
            CompositionLabel.Text += _products.Composition.ToString();
            CostLabel.Text = _products.Price.ToString();

        }

        private void ProductPictureBox_Click(object sender, EventArgs e)
        {
            CreateUpdateForm createUpdateForm = new CreateUpdateForm(_products);
            DialogResult isSaved = createUpdateForm.ShowDialog();

            if (isSaved == DialogResult.OK)
            {
                MainForm mainForm = (MainForm)this.Parent.Parent.Parent.Parent;
                mainForm.RefreshProdList();
            }
            
        }
    }
}
