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
            this.FactoryNameLabel = new System.Windows.Forms.Label();
            this.CategotyLabel = new System.Windows.Forms.Label();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.CompositionLabel = new System.Windows.Forms.Label();
            this.CostLabel = new System.Windows.Forms.Label();
            this.ProductPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // FactoryNameLabel
            // 
            this.FactoryNameLabel.AutoSize = true;
            this.FactoryNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FactoryNameLabel.Location = new System.Drawing.Point(302, 24);
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
            this.CompositionLabel.Size = new System.Drawing.Size(533, 74);
            this.CompositionLabel.TabIndex = 4;
            this.CompositionLabel.Text = "Состав:";
            // 
            // CostLabel
            // 
            this.CostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CostLabel.Location = new System.Drawing.Point(532, 52);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(209, 33);
            this.CostLabel.TabIndex = 5;
            this.CostLabel.Text = "Цена";
            this.CostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.Controls.Add(this.CostLabel);
            this.Controls.Add(this.CompositionLabel);
            this.Controls.Add(this.QuantityLabel);
            this.Controls.Add(this.CategotyLabel);
            this.Controls.Add(this.FactoryNameLabel);
            this.Controls.Add(this.ProductPictureBox);
            this.Margin = new System.Windows.Forms.Padding(20, 0, 20, 20);
            this.Name = "ProductUserControl";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Size = new System.Drawing.Size(764, 205);
            ((System.ComponentModel.ISupportInitialize)(this.ProductPictureBox)).EndInit();
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
    }
}
