using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoShoes.AppForms
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void ordersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ordersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.wonderShoesDataSet);

        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "wonderShoesDataSet.Order_Items". При необходимости она может быть перемещена или удалена.
            this.order_ItemsTableAdapter.Fill(this.wonderShoesDataSet.Order_Items);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "wonderShoesDataSet.Orders". При необходимости она может быть перемещена или удалена.
            this.ordersTableAdapter.Fill(this.wonderShoesDataSet.Orders);

        }
    }
}
