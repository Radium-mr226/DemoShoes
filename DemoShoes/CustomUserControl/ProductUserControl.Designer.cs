namespace DemoShoes.CustomUserControl
{
    partial class ProductUserControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.FactoryNameLabel = new System.Windows.Forms.Label();
            this.CategotyLabel = new System.Windows.Forms.Label();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.CompositionLabel = new System.Windows.Forms.Label();
            this.CostLabel = new System.Windows.Forms.Label();
            this.QuantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.AddToOrderButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.wonderShoesDataSet = new DemoShoes.WonderShoesDataSet();
            this.product_StockTableAdapter = new DemoShoes.WonderShoesDataSetTableAdapters.Product_StockTableAdapter();
            this.tableAdapterManager = new DemoShoes.WonderShoesDataSetTableAdapters.TableAdapterManager();
            this.productsTableAdapter = new DemoShoes.WonderShoesDataSetTableAdapters.ProductsTableAdapter();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sizeComboBox = new System.Windows.Forms.ComboBox();
            this.DelPictureBox = new System.Windows.Forms.PictureBox();
            this.ProductPictureBox = new System.Windows.Forms.PictureBox();
            this.product_StockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.QuantityNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wonderShoesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DelPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_StockBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // FactoryNameLabel
            // 
            this.FactoryNameLabel.AutoSize = true;
            this.FactoryNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FactoryNameLabel.Location = new System.Drawing.Point(188, 20);
            this.FactoryNameLabel.Name = "FactoryNameLabel";
            this.FactoryNameLabel.Size = new System.Drawing.Size(290, 24);
            this.FactoryNameLabel.TabIndex = 1;
            this.FactoryNameLabel.Text = "Производство | Наименование";
            // 
            // CategotyLabel
            // 
            this.CategotyLabel.AutoSize = true;
            this.CategotyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.CategotyLabel.Location = new System.Drawing.Point(188, 52);
            this.CategotyLabel.Name = "CategotyLabel";
            this.CategotyLabel.Size = new System.Drawing.Size(88, 18);
            this.CategotyLabel.TabIndex = 2;
            this.CategotyLabel.Text = "Категория: ";
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.QuantityLabel.Location = new System.Drawing.Point(188, 80);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(100, 18);
            this.QuantityLabel.TabIndex = 3;
            this.QuantityLabel.Text = "Количество: ";
            // 
            // CompositionLabel
            // 
            this.CompositionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.CompositionLabel.Location = new System.Drawing.Point(188, 108);
            this.CompositionLabel.Name = "CompositionLabel";
            this.CompositionLabel.Size = new System.Drawing.Size(912, 74);
            this.CompositionLabel.TabIndex = 4;
            this.CompositionLabel.Text = "Состав:";
            // 
            // CostLabel
            // 
            this.CostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CostLabel.Location = new System.Drawing.Point(891, 42);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(209, 33);
            this.CostLabel.TabIndex = 5;
            this.CostLabel.Text = "Цена";
            this.CostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // QuantityNumericUpDown
            // 
            this.QuantityNumericUpDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(178)))), ((int)(((byte)(175)))));
            this.QuantityNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuantityNumericUpDown.Location = new System.Drawing.Point(659, 85);
            this.QuantityNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.QuantityNumericUpDown.Name = "QuantityNumericUpDown";
            this.QuantityNumericUpDown.Size = new System.Drawing.Size(52, 26);
            this.QuantityNumericUpDown.TabIndex = 6;
            this.QuantityNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.QuantityNumericUpDown.ValueChanged += new System.EventHandler(this.QuantityNumericUpDown_ValueChanged);
            // 
            // AddToOrderButton
            // 
            this.AddToOrderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(178)))), ((int)(((byte)(175)))));
            this.AddToOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddToOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddToOrderButton.Location = new System.Drawing.Point(913, 77);
            this.AddToOrderButton.Name = "AddToOrderButton";
            this.AddToOrderButton.Size = new System.Drawing.Size(177, 28);
            this.AddToOrderButton.TabIndex = 7;
            this.AddToOrderButton.Text = "Добавить в корзину";
            this.AddToOrderButton.UseVisualStyleBackColor = false;
            this.AddToOrderButton.Click += new System.EventHandler(this.AddToOrderButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(504, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Выберите размер:";
            // 
            // wonderShoesDataSet
            // 
            this.wonderShoesDataSet.DataSetName = "WonderShoesDataSet";
            this.wonderShoesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // product_StockTableAdapter
            // 
            this.product_StockTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriesTableAdapter = null;
            this.tableAdapterManager.FactoriesTableAdapter = null;
            this.tableAdapterManager.Order_ItemsTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.Product_Size_RangeTableAdapter = null;
            this.tableAdapterManager.Product_StockTableAdapter = this.product_StockTableAdapter;
            this.tableAdapterManager.ProductsTableAdapter = this.productsTableAdapter;
            this.tableAdapterManager.RolesTableAdapter = null;
            this.tableAdapterManager.SubcategoriesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DemoShoes.WonderShoesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.wonderShoesDataSet;
            // 
            // sizeComboBox
            // 
            this.sizeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sizeComboBox.FormattingEnabled = true;
            this.sizeComboBox.Location = new System.Drawing.Point(659, 58);
            this.sizeComboBox.Name = "sizeComboBox";
            this.sizeComboBox.Size = new System.Drawing.Size(52, 21);
            this.sizeComboBox.TabIndex = 9;
            this.sizeComboBox.SelectedIndexChanged += new System.EventHandler(this.sizeComboBox_SelectedIndexChanged);
            // 
            // DelPictureBox
            // 
            this.DelPictureBox.Image = global::DemoShoes.Properties.Resources.cancel;
            this.DelPictureBox.Location = new System.Drawing.Point(1093, 0);
            this.DelPictureBox.Name = "DelPictureBox";
            this.DelPictureBox.Size = new System.Drawing.Size(30, 30);
            this.DelPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DelPictureBox.TabIndex = 10;
            this.DelPictureBox.TabStop = false;
            this.DelPictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ProductPictureBox
            // 
            this.ProductPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductPictureBox.Location = new System.Drawing.Point(24, 24);
            this.ProductPictureBox.Name = "ProductPictureBox";
            this.ProductPictureBox.Size = new System.Drawing.Size(158, 158);
            this.ProductPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProductPictureBox.TabIndex = 0;
            this.ProductPictureBox.TabStop = false;
            this.ProductPictureBox.Click += new System.EventHandler(this.ProductPictureBox_Click);
            // 
            // ProductUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(246)))), ((int)(((byte)(231)))));
            this.Controls.Add(this.DelPictureBox);
            this.Controls.Add(this.sizeComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddToOrderButton);
            this.Controls.Add(this.QuantityNumericUpDown);
            this.Controls.Add(this.CostLabel);
            this.Controls.Add(this.CompositionLabel);
            this.Controls.Add(this.QuantityLabel);
            this.Controls.Add(this.CategotyLabel);
            this.Controls.Add(this.FactoryNameLabel);
            this.Controls.Add(this.ProductPictureBox);
            this.Margin = new System.Windows.Forms.Padding(20, 0, 20, 20);
            this.Name = "ProductUserControl";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Size = new System.Drawing.Size(1123, 205);
            this.Load += new System.EventHandler(this.ProductUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QuantityNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wonderShoesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DelPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_StockBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ProductPictureBox;
        private System.Windows.Forms.Label FactoryNameLabel;
        private System.Windows.Forms.Label CategotyLabel;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.Label CompositionLabel;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.NumericUpDown QuantityNumericUpDown;
        private System.Windows.Forms.Button AddToOrderButton;
        private System.Windows.Forms.Label label1;
        private WonderShoesDataSet wonderShoesDataSet;
        private System.Windows.Forms.BindingSource product_StockBindingSource;
        private WonderShoesDataSetTableAdapters.Product_StockTableAdapter product_StockTableAdapter;
        private WonderShoesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private WonderShoesDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private System.Windows.Forms.ComboBox sizeComboBox;
        private System.Windows.Forms.PictureBox DelPictureBox;
    }
}
