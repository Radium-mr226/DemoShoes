namespace DemoShoes.AppForms
{
    partial class CreateUpdateForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label product_NameLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label compositionLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label id_CategoryLabel;
            System.Windows.Forms.Label id_SubcategoryLabel;
            System.Windows.Forms.Label id_FactoryLabel;
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.TitlePictureBox = new System.Windows.Forms.PictureBox();
            this.wonderShoesDataSet = new DemoShoes.WonderShoesDataSet();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new DemoShoes.WonderShoesDataSetTableAdapters.ProductsTableAdapter();
            this.tableAdapterManager = new DemoShoes.WonderShoesDataSetTableAdapters.TableAdapterManager();
            this.product_NameTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.compositionTextBox = new System.Windows.Forms.TextBox();
            this.imagePictureBox = new System.Windows.Forms.PictureBox();
            this.id_CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.id_SubcategoryComboBox = new System.Windows.Forms.ComboBox();
            this.id_FactoryComboBox = new System.Windows.Forms.ComboBox();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriesTableAdapter = new DemoShoes.WonderShoesDataSetTableAdapters.CategoriesTableAdapter();
            this.subcategoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subcategoriesTableAdapter = new DemoShoes.WonderShoesDataSetTableAdapters.SubcategoriesTableAdapter();
            this.factoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.factoriesTableAdapter = new DemoShoes.WonderShoesDataSetTableAdapters.FactoriesTableAdapter();
            this.priceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            product_NameLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            compositionLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            id_CategoryLabel = new System.Windows.Forms.Label();
            id_SubcategoryLabel = new System.Windows.Forms.Label();
            id_FactoryLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TitlePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wonderShoesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subcategoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.TitleLabel);
            this.splitContainer1.Panel1.Controls.Add(this.TitlePictureBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.CancelButton);
            this.splitContainer1.Panel2.Controls.Add(this.SaveButton);
            this.splitContainer1.Panel2.Controls.Add(this.priceNumericUpDown);
            this.splitContainer1.Panel2.Controls.Add(id_FactoryLabel);
            this.splitContainer1.Panel2.Controls.Add(this.id_FactoryComboBox);
            this.splitContainer1.Panel2.Controls.Add(id_SubcategoryLabel);
            this.splitContainer1.Panel2.Controls.Add(this.id_SubcategoryComboBox);
            this.splitContainer1.Panel2.Controls.Add(id_CategoryLabel);
            this.splitContainer1.Panel2.Controls.Add(this.id_CategoryComboBox);
            this.splitContainer1.Panel2.Controls.Add(this.imagePictureBox);
            this.splitContainer1.Panel2.Controls.Add(product_NameLabel);
            this.splitContainer1.Panel2.Controls.Add(this.product_NameTextBox);
            this.splitContainer1.Panel2.Controls.Add(descriptionLabel);
            this.splitContainer1.Panel2.Controls.Add(this.descriptionTextBox);
            this.splitContainer1.Panel2.Controls.Add(compositionLabel);
            this.splitContainer1.Panel2.Controls.Add(this.compositionTextBox);
            this.splitContainer1.Panel2.Controls.Add(priceLabel);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 112;
            this.splitContainer1.TabIndex = 1;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleLabel.Location = new System.Drawing.Point(104, 13);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(194, 32);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Чудо Обувь: ";
            // 
            // TitlePictureBox
            // 
            this.TitlePictureBox.Image = global::DemoShoes.Properties.Resources.Чудо_Обувь;
            this.TitlePictureBox.Location = new System.Drawing.Point(13, 13);
            this.TitlePictureBox.Name = "TitlePictureBox";
            this.TitlePictureBox.Size = new System.Drawing.Size(85, 85);
            this.TitlePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TitlePictureBox.TabIndex = 0;
            this.TitlePictureBox.TabStop = false;
            // 
            // wonderShoesDataSet
            // 
            this.wonderShoesDataSet.DataSetName = "WonderShoesDataSet";
            this.wonderShoesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.wonderShoesDataSet;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriesTableAdapter = this.categoriesTableAdapter;
            this.tableAdapterManager.FactoriesTableAdapter = this.factoriesTableAdapter;
            this.tableAdapterManager.Order_ItemsTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.Product_Size_RangeTableAdapter = null;
            this.tableAdapterManager.Product_StockTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = this.productsTableAdapter;
            this.tableAdapterManager.RolesTableAdapter = null;
            this.tableAdapterManager.SubcategoriesTableAdapter = this.subcategoriesTableAdapter;
            this.tableAdapterManager.UpdateOrder = DemoShoes.WonderShoesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // product_NameLabel
            // 
            product_NameLabel.AutoSize = true;
            product_NameLabel.Location = new System.Drawing.Point(47, 128);
            product_NameLabel.Name = "product_NameLabel";
            product_NameLabel.Size = new System.Drawing.Size(135, 13);
            product_NameLabel.TabIndex = 10;
            product_NameLabel.Text = "Наименование продукта:";
            // 
            // product_NameTextBox
            // 
            this.product_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "Product_Name", true));
            this.product_NameTextBox.Location = new System.Drawing.Point(190, 127);
            this.product_NameTextBox.Name = "product_NameTextBox";
            this.product_NameTextBox.Size = new System.Drawing.Size(316, 20);
            this.product_NameTextBox.TabIndex = 11;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(47, 155);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(60, 13);
            descriptionLabel.TabIndex = 12;
            descriptionLabel.Text = "Описание:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(190, 153);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(316, 20);
            this.descriptionTextBox.TabIndex = 13;
            // 
            // compositionLabel
            // 
            compositionLabel.AutoSize = true;
            compositionLabel.Location = new System.Drawing.Point(47, 186);
            compositionLabel.Name = "compositionLabel";
            compositionLabel.Size = new System.Drawing.Size(46, 13);
            compositionLabel.TabIndex = 14;
            compositionLabel.Text = "Состав:";
            // 
            // compositionTextBox
            // 
            this.compositionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "Composition", true));
            this.compositionTextBox.Location = new System.Drawing.Point(190, 183);
            this.compositionTextBox.Name = "compositionTextBox";
            this.compositionTextBox.Size = new System.Drawing.Size(316, 20);
            this.compositionTextBox.TabIndex = 15;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(47, 209);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(36, 13);
            priceLabel.TabIndex = 16;
            priceLabel.Text = "Цена:";
            // 
            // imagePictureBox
            // 
            this.imagePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imagePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.productsBindingSource, "Image", true));
            this.imagePictureBox.Location = new System.Drawing.Point(535, 33);
            this.imagePictureBox.Name = "imagePictureBox";
            this.imagePictureBox.Size = new System.Drawing.Size(220, 220);
            this.imagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagePictureBox.TabIndex = 18;
            this.imagePictureBox.TabStop = false;
            this.imagePictureBox.Click += new System.EventHandler(this.imagePictureBox_Click);
            // 
            // id_CategoryLabel
            // 
            id_CategoryLabel.AutoSize = true;
            id_CategoryLabel.Location = new System.Drawing.Point(47, 47);
            id_CategoryLabel.Name = "id_CategoryLabel";
            id_CategoryLabel.Size = new System.Drawing.Size(117, 13);
            id_CategoryLabel.TabIndex = 18;
            id_CategoryLabel.Text = "Выберите категорию:";
            // 
            // id_CategoryComboBox
            // 
            this.id_CategoryComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "Id_Category", true));
            this.id_CategoryComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productsBindingSource, "Id_Category", true));
            this.id_CategoryComboBox.DataSource = this.categoriesBindingSource;
            this.id_CategoryComboBox.DisplayMember = "Category_Name";
            this.id_CategoryComboBox.FormattingEnabled = true;
            this.id_CategoryComboBox.Location = new System.Drawing.Point(190, 46);
            this.id_CategoryComboBox.Name = "id_CategoryComboBox";
            this.id_CategoryComboBox.Size = new System.Drawing.Size(316, 21);
            this.id_CategoryComboBox.TabIndex = 19;
            this.id_CategoryComboBox.ValueMember = "Id_Category";
            // 
            // id_SubcategoryLabel
            // 
            id_SubcategoryLabel.AutoSize = true;
            id_SubcategoryLabel.Location = new System.Drawing.Point(47, 74);
            id_SubcategoryLabel.Name = "id_SubcategoryLabel";
            id_SubcategoryLabel.Size = new System.Drawing.Size(135, 13);
            id_SubcategoryLabel.TabIndex = 19;
            id_SubcategoryLabel.Text = "Выберите подкатегорию:";
            // 
            // id_SubcategoryComboBox
            // 
            this.id_SubcategoryComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "Id_Subcategory", true));
            this.id_SubcategoryComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productsBindingSource, "Id_Subcategory", true));
            this.id_SubcategoryComboBox.DataSource = this.subcategoriesBindingSource;
            this.id_SubcategoryComboBox.DisplayMember = "Subcategory_Name";
            this.id_SubcategoryComboBox.FormattingEnabled = true;
            this.id_SubcategoryComboBox.Location = new System.Drawing.Point(190, 73);
            this.id_SubcategoryComboBox.Name = "id_SubcategoryComboBox";
            this.id_SubcategoryComboBox.Size = new System.Drawing.Size(316, 21);
            this.id_SubcategoryComboBox.TabIndex = 20;
            this.id_SubcategoryComboBox.ValueMember = "Id_Subcategory";
            // 
            // id_FactoryLabel
            // 
            id_FactoryLabel.AutoSize = true;
            id_FactoryLabel.Location = new System.Drawing.Point(47, 101);
            id_FactoryLabel.Name = "id_FactoryLabel";
            id_FactoryLabel.Size = new System.Drawing.Size(140, 13);
            id_FactoryLabel.TabIndex = 20;
            id_FactoryLabel.Text = "Выберите производителя:";
            // 
            // id_FactoryComboBox
            // 
            this.id_FactoryComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "Id_Factory", true));
            this.id_FactoryComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productsBindingSource, "Id_Factory", true));
            this.id_FactoryComboBox.DataSource = this.factoriesBindingSource;
            this.id_FactoryComboBox.DisplayMember = "Factory_Name";
            this.id_FactoryComboBox.FormattingEnabled = true;
            this.id_FactoryComboBox.Location = new System.Drawing.Point(190, 100);
            this.id_FactoryComboBox.Name = "id_FactoryComboBox";
            this.id_FactoryComboBox.Size = new System.Drawing.Size(316, 21);
            this.id_FactoryComboBox.TabIndex = 21;
            this.id_FactoryComboBox.ValueMember = "Id_Factory";
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "Categories";
            this.categoriesBindingSource.DataSource = this.wonderShoesDataSet;
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // subcategoriesBindingSource
            // 
            this.subcategoriesBindingSource.DataMember = "Subcategories";
            this.subcategoriesBindingSource.DataSource = this.wonderShoesDataSet;
            // 
            // subcategoriesTableAdapter
            // 
            this.subcategoriesTableAdapter.ClearBeforeFill = true;
            // 
            // factoriesBindingSource
            // 
            this.factoriesBindingSource.DataMember = "Factories";
            this.factoriesBindingSource.DataSource = this.wonderShoesDataSet;
            // 
            // factoriesTableAdapter
            // 
            this.factoriesTableAdapter.ClearBeforeFill = true;
            // 
            // priceNumericUpDown
            // 
            this.priceNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productsBindingSource, "Price", true));
            this.priceNumericUpDown.DecimalPlaces = 2;
            this.priceNumericUpDown.Location = new System.Drawing.Point(190, 209);
            this.priceNumericUpDown.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.priceNumericUpDown.Name = "priceNumericUpDown";
            this.priceNumericUpDown.Size = new System.Drawing.Size(316, 20);
            this.priceNumericUpDown.TabIndex = 22;
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(178)))), ((int)(((byte)(175)))));
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveButton.Location = new System.Drawing.Point(123, 279);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(219, 36);
            this.SaveButton.TabIndex = 23;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(178)))), ((int)(((byte)(175)))));
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelButton.Location = new System.Drawing.Point(381, 279);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(219, 36);
            this.CancelButton.TabIndex = 24;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // CreateUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "CreateUpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CreateUpdateForm";
            this.Load += new System.EventHandler(this.CreateUpdateForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TitlePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wonderShoesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subcategoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.PictureBox TitlePictureBox;
        private WonderShoesDataSet wonderShoesDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private WonderShoesDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private WonderShoesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.PictureBox imagePictureBox;
        private System.Windows.Forms.TextBox product_NameTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox compositionTextBox;
        private System.Windows.Forms.ComboBox id_FactoryComboBox;
        private System.Windows.Forms.ComboBox id_SubcategoryComboBox;
        private System.Windows.Forms.ComboBox id_CategoryComboBox;
        private WonderShoesDataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private WonderShoesDataSetTableAdapters.SubcategoriesTableAdapter subcategoriesTableAdapter;
        private System.Windows.Forms.BindingSource subcategoriesBindingSource;
        private WonderShoesDataSetTableAdapters.FactoriesTableAdapter factoriesTableAdapter;
        private System.Windows.Forms.BindingSource factoriesBindingSource;
        private System.Windows.Forms.NumericUpDown priceNumericUpDown;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SaveButton;
    }
}