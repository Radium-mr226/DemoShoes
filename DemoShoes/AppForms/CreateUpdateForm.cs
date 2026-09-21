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

namespace DemoShoes.AppForms
{
    public partial class CreateUpdateForm : Form
    {
        private Products _products;
        public CreateUpdateForm()
        {
            InitializeComponent();
            _products = null;
        }
        public CreateUpdateForm(Products products)
        {
            InitializeComponent();
            _products = products;
        }

        private void CreateUpdateForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "wonderShoesDataSet.Factories". При необходимости она может быть перемещена или удалена.
            this.factoriesTableAdapter.Fill(this.wonderShoesDataSet.Factories);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "wonderShoesDataSet.Subcategories". При необходимости она может быть перемещена или удалена.
            this.subcategoriesTableAdapter.Fill(this.wonderShoesDataSet.Subcategories);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "wonderShoesDataSet.Categories". При необходимости она может быть перемещена или удалена.
            this.categoriesTableAdapter.Fill(this.wonderShoesDataSet.Categories);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "wonderShoesDataSet.Products". При необходимости она может быть перемещена или удалена.
            this.productsTableAdapter.Fill(this.wonderShoesDataSet.Products);


            string dir = Path.GetFullPath(Path.Combine(
               AppDomain.CurrentDomain.BaseDirectory, @"..\..\Resources\Images"));
            string path = Path.Combine(dir, _products.Image ?? "");

            if (!string.IsNullOrEmpty(_products.Image) && File.Exists(path))
            {
                using (var img = Image.FromFile(path))
                    imagePictureBox.Image = new Bitmap(img); // копия, чтобы файл не оставался заблокированным
            }
            else
            {
                imagePictureBox.Image = null; // заглушка из ресурсов
                MessageBox.Show(path + "\nСуществует: " + File.Exists(path));

            }

        }

        private void imagePictureBox_Click(object sender, EventArgs e)
        {
            using (var dialog = new OpenFileDialog())
            {
                dialog.Title = "Выберите фото";
                dialog.Filter = "Изображения|*.jpg;*.jpeg;*.png";

                if (dialog.ShowDialog() != DialogResult.OK)
                    return;

                string dir = Path.GetFullPath(Path.Combine(
                    AppDomain.CurrentDomain.BaseDirectory, @"..\..\Resources\Images"));
                Directory.CreateDirectory(dir);

                string fileName = Path.GetFileName(dialog.FileName);
                string destPath = Path.Combine(dir, fileName);

                if (File.Exists(destPath) &&
                    new FileInfo(destPath).Length != new FileInfo(dialog.FileName).Length)
                {
                    // имя занято другим файлом: подбираем свободное
                    string name = Path.GetFileNameWithoutExtension(fileName);
                    string ext = Path.GetExtension(fileName);
                    int i = 1;
                    do
                    {
                        fileName = $"{name}_{i++}{ext}";
                        destPath = Path.Combine(dir, fileName);
                    } while (File.Exists(destPath));
                }

                if (!File.Exists(destPath))
                    File.Copy(dialog.FileName, destPath);

                using (var img = Image.FromFile(destPath))
                    imagePictureBox.Image = new Bitmap(img);

                _products.Image = fileName;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (_products != null)
            {
                _products.Id_Category = Convert.ToInt16(id_CategoryComboBox.SelectedValue);
                _products.Id_Subcategory = Convert.ToInt16(id_SubcategoryComboBox.SelectedValue);
                _products.Id_Factory = Convert.ToInt16(id_FactoryComboBox.SelectedValue);
                _products.Product_Name = product_NameTextBox.Text;
                _products.Description = descriptionTextBox.Text;
                _products.Composition = compositionTextBox.Text;
                _products.Price = Convert.ToDecimal(priceNumericUpDown.Value);
                Program.context.SaveChanges();
                MessageBox.Show("Данные сохранены", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
