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
        private bool _type;
        private List<Product_Stock> sizes;
        public ProductUserControl(Products products, bool type)
        {
            InitializeComponent();
            _products = products;
            _type = type;
            
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

            Product_Stock quantity = sizeComboBox.SelectedItem as Product_Stock;
            QuantityNumericUpDown.Maximum = quantity.Quantity;
            

            if (sizes.Count > 0)
                sizeComboBox.SelectedIndex = 0;

            if (_type)
            {
                QuantityNumericUpDown.Visible = false;
                QuantityLabel.Text = "Количество: " + quantity.Quantity.ToString();
            }
            else
            {
                QuantityNumericUpDown.Visible = true;
            }

            FactoryNameLabel.Text = _products.Factories.Factory_Name.ToString() + " | " + _products.Product_Name.ToString();
            CategotyLabel.Text = "Категория: " + _products.Categories.Category_Name.ToString();
            CompositionLabel.Text = "Состав" + _products.Composition.ToString();
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

        private void AddToOrderButton_Click(object sender, EventArgs e)
        {
            this.AddToOrderButton.Visible = false;
            MainForm mainForm = (MainForm)this.Parent.Parent.Parent.Parent;
            //Order_Items order_Items = new Order_Items();
            //order_Items.Unit_Price = _products.Price;
            //order_Items.Quantity = 1;
            //order_Items.Id_Product = _products.Id_Product;
            //order_Items.Id_Order = mainForm._order.Id_Order;
            //order_Items.Size = 
            mainForm._order.Add(_products);

        }

        private void sizeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillFields();
        }

        private void ProductUserControl_Load(object sender, EventArgs e)
        {
            //размеры конкретного товара
            sizes = Program.context.Product_Stock
                .Where(p => p.Id_Product == _products.Id_Product)
                .OrderBy(p => p.Size)
                .ToList();

            sizeComboBox.DataSource = sizes;
            sizeComboBox.DisplayMember = "Size";
            sizeComboBox.ValueMember = "Size";
            FillFields();
        }
    }
}
