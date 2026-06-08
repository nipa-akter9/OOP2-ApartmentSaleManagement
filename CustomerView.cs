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
    public partial class CustomerView: Form
    {
        int customerId;
        public CustomerView(int customerId)
        {
            InitializeComponent();
            this.customerId = customerId;
        }
        private void CustomerView_Load(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM Apartment";
                DataTable data = DataAccess.GetData(query);
                if (data == null)
                    return;

                dgvCView.AutoGenerateColumns = false;
                dgvCView.DataSource = data;
                dgvCView.Refresh();
                dgvCView.ClearSelection();
              
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (dgvCView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an apartment to order.");
                return;
            }

            // Get the selected ApartmentID
             string apartmentId = dgvCView.SelectedRows[0].Cells[0].Value.ToString();


            // For simplicity, set OrderBy as a hardcoded customer name or use session if available
            

            try
            {
                string update = $"UPDATE Apartment SET OrderBy = {customerId} WHERE ApartmentID = {apartmentId}";

                if (DataAccess.ExecuteQuery(update))
                {
                    MessageBox.Show("Apartment ordered successfully.");
                    CustomerView_Load(sender, e); // Reload grid
                }
                else
                {
                    MessageBox.Show("Order failed.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            CustomerDashBoard cd = new CustomerDashBoard(customerId);
            cd.Show();
            this.Hide();
        }

        private void NumericUD_ValueChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    int price = (int)NumericUD.Value; 
            //    string query = $"SELECT * FROM Apartment WHERE OrderBy IS NULL AND Price = {price}";

            //    DataTable data = DataAccess.GetData(query);
            //    if (data == null)
            //        return;

            //    dgvCView.AutoGenerateColumns = false;
            //    dgvCView.DataSource = data;
            //    dgvCView.ClearSelection();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error: " + ex.Message);
            //}
            //try
            //{
            //    int price = (int)NumericUD.Value;
            //    string query = $"SELECT * FROM Apartment WHERE OrderBy IS NULL AND Price = {price}";

            //    DataTable data = DataAccess.GetData(query);
            //    if (data == null)
            //        return;

            //    // Sort the DataTable by Price in ascending order
            //    DataView dv = data.DefaultView;
            //    dv.Sort = "Price ASC"; // Use "Price DESC" for descending order

            //    dgvCView.AutoGenerateColumns = false;
            //    dgvCView.DataSource = dv.ToTable();
            //    dgvCView.ClearSelection();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error: " + ex.Message);
            //}

        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            LoadAndSortApartments("Price", "ASC");
        }
        private void LoadAndSortApartmentsDESC()
        {
            // Step 1: Load data from database
            DataTable dt = DataAccess.GetData("SELECT * FROM Apartment");

            // Step 2: Check if data is loaded
            if (dt != null)
            {
                // Step 3: Create a DataView and sort by Price DESC
                DataView dv = dt.DefaultView;
                dv.Sort = "Price DESC"; // descending order

                // Step 4: Set the DataGridView to use the sorted data
                dgvCView.DataSource = dv;
            }
        }

        private void LoadAndSortApartments(string sortColumn = "Price", string sortDirection = "ASC")
        {
            DataTable dt = DataAccess.GetData("SELECT * FROM Apartment");

            if (dt != null)
            {
                DataView dv = dt.DefaultView;
                dv.Sort = $"{sortColumn} {sortDirection}";

                dgvCView.DataSource = dv;
            }
        }

        private void btnDsort_Click(object sender, EventArgs e)
        {
            LoadAndSortApartmentsDESC();
        }
    }
}

