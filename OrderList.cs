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
    public partial class OrderList : Form
    {
        public OrderList()
        {
            InitializeComponent();
        }

        private void OrderList_Load(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM Apartment WHERE OrderBy IS NOT NULL";
                DataTable data = DataAccess.GetData(query);
                if (data == null)
                    return;

                dgvOrder.AutoGenerateColumns = false;
                dgvOrder.DataSource = data;
                dgvOrder.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminDashboard ad = new AdminDashboard();
            ad.Show();
            this.Hide();
        }

        private void dgvOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtID.Text = dgvOrder.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtLoc.Text = dgvOrder.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtSize.Text = dgvOrder.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtPrice.Text = dgvOrder.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtOrder.Text = dgvOrder.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            if (id == "")
            {
                MessageBox.Show("Please select a row first");
                return;
            }

            var result = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
                return;

            var query = $"DELETE FROM Apartment WHERE ApartmentID={id}";
            if (DataAccess.ExecuteQuery(query) == false)
                return;

            MessageBox.Show("Deleted");
            LoadData(); // Call the LoadData method to refresh the data grid.
        }

        // Add the missing LoadData method to fix the CS1061 error.
        private void LoadData()
        {
            try
            {
                string query = "SELECT * FROM Apartment WHERE OrderBy IS NOT NULL";
                DataTable data = DataAccess.GetData(query);
                if (data == null)
                    return;

                dgvOrder.DataSource = data;
                dgvOrder.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnMpay_Click(object sender, EventArgs e)
        {
            if (dgvOrder.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an order to make payment.");
                return;
            }

            // Get the selected ApartmentID (assuming it's in the first column)
            string apartmentId = dgvOrder.SelectedRows[0].Cells[0].Value.ToString();

            MakePayment mp = new MakePayment(apartmentId);
            mp.Show();
            this.Hide();
        }
    }
}
