namespace DemoShoes.CustomUserControl
{
    partial class OrderUserControl
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
            this.orderIdLabel = new System.Windows.Forms.Label();
            this.sumOrderLabel = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.quantityProdLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // orderIdLabel
            // 
            this.orderIdLabel.AutoSize = true;
            this.orderIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderIdLabel.Location = new System.Drawing.Point(23, 20);
            this.orderIdLabel.Name = "orderIdLabel";
            this.orderIdLabel.Size = new System.Drawing.Size(77, 20);
            this.orderIdLabel.TabIndex = 0;
            this.orderIdLabel.Text = "Заказ № ";
            this.orderIdLabel.Click += new System.EventHandler(this.orderIdLabel_Click);
            // 
            // sumOrderLabel
            // 
            this.sumOrderLabel.AutoSize = true;
            this.sumOrderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sumOrderLabel.Location = new System.Drawing.Point(23, 67);
            this.sumOrderLabel.Name = "sumOrderLabel";
            this.sumOrderLabel.Size = new System.Drawing.Size(130, 20);
            this.sumOrderLabel.TabIndex = 1;
            this.sumOrderLabel.Text = "Сумма заказа = ";
            this.sumOrderLabel.Click += new System.EventHandler(this.orderIdLabel_Click);
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userLabel.Location = new System.Drawing.Point(23, 114);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(96, 20);
            this.userLabel.TabIndex = 2;
            this.userLabel.Text = "Заказал(а) ";
            this.userLabel.Click += new System.EventHandler(this.orderIdLabel_Click);
            // 
            // quantityProdLabel
            // 
            this.quantityProdLabel.AutoSize = true;
            this.quantityProdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quantityProdLabel.Location = new System.Drawing.Point(23, 161);
            this.quantityProdLabel.Name = "quantityProdLabel";
            this.quantityProdLabel.Size = new System.Drawing.Size(170, 20);
            this.quantityProdLabel.TabIndex = 3;
            this.quantityProdLabel.Text = "Количество позиций ";
            this.quantityProdLabel.Click += new System.EventHandler(this.orderIdLabel_Click);
            // 
            // OrderUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(246)))), ((int)(((byte)(231)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.quantityProdLabel);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.sumOrderLabel);
            this.Controls.Add(this.orderIdLabel);
            this.Margin = new System.Windows.Forms.Padding(20, 0, 20, 20);
            this.Name = "OrderUserControl";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Size = new System.Drawing.Size(727, 201);
            this.Load += new System.EventHandler(this.OrderUserControl_Load);
            this.Click += new System.EventHandler(this.orderIdLabel_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label orderIdLabel;
        private System.Windows.Forms.Label sumOrderLabel;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label quantityProdLabel;
    }
}
