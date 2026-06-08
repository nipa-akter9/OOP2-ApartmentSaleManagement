using NewProject;
using System;
using System.Collections;
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
    public partial class MakePayment: Form
    {
        private string selectedApartmentId;

        public MakePayment(string apartmentId = null)
        {
            InitializeComponent();
            this.selectedApartmentId = apartmentId;
        }

        public MakePayment()
        {
            InitializeComponent();
        }
        public void loadData()
        {
            //    string query = $"select * from [Payment]";

            //    var data = DataAccess.GetData(query);
            //    if (data == null)
            //    {
            //        MessageBox.Show("Nothing");
            //        return;
            //    }
            //    dgvPayment.AutoGenerateColumns = false;
            //    dgvPayment.DataSource = data;

            //    dgvPayment.Refresh();
            //    dgvPayment.ClearSelection();

            string query;
            if (!string.IsNullOrEmpty(selectedApartmentId))
            {
                query = $@"SELECT 
                p.PaymentID, 
                p.CustomerID, 
                p.ApartmentID, 
                p.PaymentDate, 
                p.Status, 
                a.Price
            FROM 
                Payment p
            JOIN 
                Apartment a ON p.ApartmentID = a.ApartmentID
            WHERE p.ApartmentID = '{selectedApartmentId}'";
            }
            else
            {
                query = @"SELECT 
                p.PaymentID, 
                p.CustomerID, 
                p.ApartmentID, 
                p.PaymentDate, 
                p.Status, 
                a.Price
            FROM 
                Payment p
            JOIN 
                Apartment a ON p.ApartmentID = a.ApartmentID";
            }
            var data = DataAccess.GetData(query);

            dgvPayment.AutoGenerateColumns = true;
            dgvPayment.DataSource = data;
            dgvPayment.Refresh();
            dgvPayment.ClearSelection();

            // If no payment records, pre-fill apartment info for new payment
            if (data == null || data.Rows.Count == 0)
            {
                if (!string.IsNullOrEmpty(selectedApartmentId))
                {
                    string aptQuery = $"SELECT ApartmentID, Price FROM Apartment WHERE ApartmentID = '{selectedApartmentId}'";
                    var aptData = DataAccess.GetData(aptQuery);
                    if (aptData != null && aptData.Rows.Count > 0)
                    {
                        txtAP.Text = aptData.Rows[0]["ApartmentID"].ToString();
                        txtPrice.Text = aptData.Rows[0]["Price"].ToString();
                    }
                }
            }
        }
    

        public void celarData()
        {
            dgvPayment.ClearSelection();
            txtPID.Text = "";
            txtCID.Text = "";
            txtAP.Text = "";
            txtPD.Value = DateTime.Now;
            txtPrice.Text = "";
        }

        private void MakePayment_Load(object sender, EventArgs e)
        {
            this.loadData();
        }

        private void dgvPayment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtPID.Text = dgvPayment.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtCID.Text = dgvPayment.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtAP.Text = dgvPayment.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtPD.Value = Convert.ToDateTime(dgvPayment.Rows[e.RowIndex].Cells[3].Value);
                txtPrice.Text = dgvPayment.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string id = txtPID.Text;
            string cid = txtCID.Text;
            string ap = txtAP.Text;
            DateTime pd = txtPD.Value;
            string status = txtPrice.Text;
            if (cid == "")
            {
                MessageBox.Show("Please enter Customer ID.");
                txtCID.Focus();
                return;
            }
            if (ap == "")
            {
                MessageBox.Show("Please enter Apartment ID.");
                txtAP.Focus();
                return;
            }
            if (status == "")
            {
                MessageBox.Show("Please enter Status.");
                txtPrice.Focus();
                return;
            }

            //string query = $"INSERT INTO Payment (CustomerID, ApartmentID, PaymentDate, Status) " +
            //               $"VALUES ('{cid}', '{ap}', '{pd}', '{status}')";

            //if (DataAccess.ExecuteQuery(query))
            //{
            //    MessageBox.Show("Payment record inserted successfully.");
            //    this.loadData();
            //    this.celarData();
            //}
            //else
            //{
            //    MessageBox.Show("Something went wrong while inserting.");
            //}


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            OrderList ol = new OrderList();
            ol.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = txtPID.Text;
            if (id == "")
            {
                MessageBox.Show("Please select a payment record to delete.");
                txtPID.Focus();
                return;
            }

            var result = MessageBox.Show("Are you sure you want to delete this payment?", "Confirmation", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
            {
                return;
            }

            string query = $"DELETE FROM Payment WHERE PaymentID = '{id}'";

            if (DataAccess.ExecuteQuery(query))
            {
                MessageBox.Show("Payment record deleted successfully.");
                this.loadData();
                this.celarData();
            }
            else
            {
                MessageBox.Show("Something went wrong while deleting.");
            }
        }
    }
    
}
