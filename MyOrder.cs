using NewProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApartmentSaleManagement
{
    public partial class MyOrder: Form
    {
        int customerId;
        public MyOrder(int customerId)
        {
            InitializeComponent();
            this.customerId = customerId;
        }

        private void MyOrder_Load(object sender, EventArgs e)
        {
            try
            {
                string query = $"SELECT * FROM Apartment WHERE OrderBy = {customerId}";

                DataTable data = DataAccess.GetData(query);
                if (data == null)
                    return;

                dgvMyOrder.AutoGenerateColumns = false;
                dgvMyOrder.DataSource = data;
                dgvMyOrder.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnMback_Click(object sender, EventArgs e)
        {
            CustomerDashBoard cd = new CustomerDashBoard(customerId);
            cd.Show();
            this.Hide();
        }
    }
}
