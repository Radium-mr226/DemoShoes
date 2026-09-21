namespace DemoShoes.AppForms
{
    partial class AutorizationForm
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
            System.Windows.Forms.Label loginLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutorizationForm));
            this.wonderShoesDataSet = new DemoShoes.WonderShoesDataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new DemoShoes.WonderShoesDataSetTableAdapters.UsersTableAdapter();
            this.tableAdapterManager = new DemoShoes.WonderShoesDataSetTableAdapters.TableAdapterManager();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.GuestButton = new System.Windows.Forms.Button();
            this.AuthButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.TitlePictureBox = new System.Windows.Forms.PictureBox();
            loginLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.wonderShoesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TitlePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // wonderShoesDataSet
            // 
            this.wonderShoesDataSet.DataSetName = "WonderShoesDataSet";
            this.wonderShoesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.wonderShoesDataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriesTableAdapter = null;
            this.tableAdapterManager.FactoriesTableAdapter = null;
            this.tableAdapterManager.Order_ItemsTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.Product_Size_RangeTableAdapter = null;
            this.tableAdapterManager.Product_StockTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.RolesTableAdapter = null;
            this.tableAdapterManager.SubcategoriesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DemoShoes.WonderShoesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = this.usersTableAdapter;
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
            this.splitContainer1.Panel2.Controls.Add(this.AuthButton);
            this.splitContainer1.Panel2.Controls.Add(this.GuestButton);
            this.splitContainer1.Panel2.Controls.Add(loginLabel);
            this.splitContainer1.Panel2.Controls.Add(this.loginTextBox);
            this.splitContainer1.Size = new System.Drawing.Size(483, 283);
            this.splitContainer1.SplitterDistance = 112;
            this.splitContainer1.TabIndex = 1;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleLabel.Location = new System.Drawing.Point(104, 13);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(371, 32);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Чудо Обувь: Авторизация";
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            loginLabel.Location = new System.Drawing.Point(12, 49);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new System.Drawing.Size(150, 24);
            loginLabel.TabIndex = 0;
            loginLabel.Text = "Введите логин:";
            // 
            // loginTextBox
            // 
            this.loginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginTextBox.Location = new System.Drawing.Point(168, 46);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(303, 29);
            this.loginTextBox.TabIndex = 1;
            // 
            // GuestButton
            // 
            this.GuestButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(178)))), ((int)(((byte)(175)))));
            this.GuestButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GuestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GuestButton.Location = new System.Drawing.Point(13, 119);
            this.GuestButton.Name = "GuestButton";
            this.GuestButton.Size = new System.Drawing.Size(146, 36);
            this.GuestButton.TabIndex = 2;
            this.GuestButton.Text = "Войти как гость";
            this.GuestButton.UseVisualStyleBackColor = false;
            this.GuestButton.Click += new System.EventHandler(this.GuestButton_Click);
            // 
            // AuthButton
            // 
            this.AuthButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(178)))), ((int)(((byte)(175)))));
            this.AuthButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AuthButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthButton.Location = new System.Drawing.Point(167, 119);
            this.AuthButton.Name = "AuthButton";
            this.AuthButton.Size = new System.Drawing.Size(146, 36);
            this.AuthButton.TabIndex = 3;
            this.AuthButton.Text = "Войти";
            this.AuthButton.UseVisualStyleBackColor = false;
            this.AuthButton.Click += new System.EventHandler(this.AuthButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(178)))), ((int)(((byte)(175)))));
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelButton.Location = new System.Drawing.Point(321, 119);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(146, 36);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
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
            // AutorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 283);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AutorizationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.AutorizationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wonderShoesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TitlePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private WonderShoesDataSet wonderShoesDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private WonderShoesDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private WonderShoesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.PictureBox TitlePictureBox;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button AuthButton;
        private System.Windows.Forms.Button GuestButton;
    }
}