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
        private bool _type = true;
        private List<Product_Stock> sizes;
        private Order_Items _orderItems;
        private bool _isLoading = false;

        public ProductUserControl(Products products, bool type)
        {
            InitializeComponent();
            _products = products;
            _type = type;
            
        }

        public ProductUserControl(Order_Items order_Items, bool type)
        {
            InitializeComponent();
            _orderItems = order_Items;
            _products = Program.context.Products.FirstOrDefault(p=> p.Id_Product == _orderItems.Id_Product);
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
            if (quantity != null)
            {
                QuantityNumericUpDown.Maximum = quantity.Quantity;
                QuantityLabel.Text = "Количество: " + quantity.Quantity.ToString();

                // синхронизируем ТОЛЬКО когда это реальный выбор пользователя, а не программная инициализация
                if (_orderItems != null && !_isLoading)
                {
                    _orderItems.Size = quantity.Size;
                }
            }


            if (_type)
            {

                QuantityNumericUpDown.Visible = false;
                DelPictureBox.Visible = false;

                MainForm mainForm = this.FindForm() as MainForm;
                bool alreadyInOrder = mainForm != null &&
                    mainForm._orderList.Any(o => o.Id_Product == _products.Id_Product);

                AddToOrderButton.Visible = !alreadyInOrder;
            }
            else
            {
                AddToOrderButton.Visible = false;
                QuantityNumericUpDown.Visible = true;
            }

            FactoryNameLabel.Text = _products.Factories.Factory_Name.ToString() + " | " + _products.Product_Name.ToString();
            CategotyLabel.Text = "Категория: " + _products.Categories.Category_Name.ToString();
            CompositionLabel.Text = "Состав" + _products.Composition.ToString();
            CostLabel.Text = _products.Price.ToString();
        }

        private void ProductPictureBox_Click(object sender, EventArgs e)
        {
            if (_type == true)
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

        private void AddToOrderButton_Click(object sender, EventArgs e)
        {
            Product_Stock quantity = sizeComboBox.SelectedItem as Product_Stock;
            this.AddToOrderButton.Visible = false;
            MainForm mainForm = (MainForm)this.Parent.Parent.Parent.Parent;

            Order_Items order_Items = new Order_Items();
            order_Items.Unit_Price = _products.Price;
            order_Items.Quantity = 1;
            order_Items.Id_Product = _products.Id_Product;
            order_Items.Id_Order = mainForm._order.Id_Order;
            order_Items.Size = quantity.Size;

            mainForm._orderList.Add(order_Items);
        }

        private void sizeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillFields();
        }

        private void ProductUserControl_Load(object sender, EventArgs e)
        {
            _isLoading = true;

            //размеры конкретного товара
            sizes = Program.context.Product_Stock
                .Where(p => p.Id_Product == _products.Id_Product && p.Quantity >0)
                .OrderBy(p => p.Size)
                .ToList();

            sizeComboBox.DataSource = sizes;
            sizeComboBox.DisplayMember = "Size";
            sizeComboBox.ValueMember = "Size";

            if (_orderItems != null)
            {
                var savedSize = sizes.FirstOrDefault(s => s.Size == _orderItems?.Size);
                sizeComboBox.SelectedItem = savedSize ?? (sizes.Count > 0 ? sizes[0] : null);
                QuantityNumericUpDown.Value = _orderItems.Quantity;
            }
            else if (sizes.Count > 0)
            {
                sizeComboBox.SelectedIndex = 0;
            }

            _isLoading = false;

            FillFields();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (_orderItems == null) return; // на всякий случай — кнопка нужна только в заказе

            OrderForm orderForm = this.FindForm() as OrderForm;
            orderForm?.RemoveOrderItem(_orderItems, this);
        }

        private void QuantityNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (_orderItems == null || _isLoading) return;

            _orderItems.Quantity = (int)QuantityNumericUpDown.Value;

            OrderForm orderForm = this.FindForm() as OrderForm;
            orderForm?.RecalculateTotal();
        }
    }
}
