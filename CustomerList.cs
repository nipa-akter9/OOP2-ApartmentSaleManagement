using NewProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApartmentSaleManagement
{
    public partial class CustomerList: Form
    {
        public CustomerList()
        {
            InitializeComponent();
        }

        private void CustomerList_Load(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT CustomerID, CName, Email, Phone FROM Customer";

                DataTable data = DataAccess.GetData(query);
                if (data == null)
                    return;

                dgvCus.AutoGenerateColumns = false;
                dgvCus.DataSource = data;
                dgvCus.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void btnCBack_Click(object sender, EventArgs e)
        {
            AdminDashboard ad = new AdminDashboard();
            ad.Show();
            this.Hide();

        }
    }
}
