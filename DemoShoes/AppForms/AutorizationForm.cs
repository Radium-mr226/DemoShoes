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

namespace DemoShoes.AppForms
{
    public partial class AutorizationForm : Form
    {
        public AutorizationForm()
        {
            InitializeComponent();
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.wonderShoesDataSet);

        }

        private void AutorizationForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "wonderShoesDataSet.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.wonderShoesDataSet.Users);

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AuthButton_Click(object sender, EventArgs e)
        {
            var user = Program.context.Users.FirstOrDefault(p => p.Login == loginTextBox.Text);

            if (user != null)
            {
                MainForm mainForm = new MainForm(user);
                this.Visible = false;
                mainForm.ShowDialog();
                this.Visible = true;
            } 
            else
            {
                MessageBox.Show($"Нет пользователя с логином {loginTextBox.Text}", "Ошибка входа", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
                
        }

        private void GuestButton_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            this.Visible = false;
            mainForm.ShowDialog();
            this.Visible = true;
        }
    }
}
