using NewProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApartmentSaleManagement
{
    public partial class ApartmentManagerView: Form
    {
        public ApartmentManagerView()
        {
            InitializeComponent();
        }

        private void ApartmentManagerView_Load(object sender, EventArgs e)
        {
            this.LoadData();
        }
        private void LoadData()
        {
            var query = $"SELECT * FROM Apartment ";
            var data = DataAccess.GetData(query);
            if (data == null)
                return;
            dgvApartment.AutoGenerateColumns = false;
            dgvApartment.DataSource = data;
            dgvApartment.Refresh();
            dgvApartment.ClearSelection();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

            this.LoadData();
            this.Newdata();
        }

        private void dgvAppartment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtID.Text = dgvApartment.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtLoc.Text = dgvApartment.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtSize.Text = dgvApartment.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtPrice.Text = dgvApartment.Rows[e.RowIndex].Cells[3].Value.ToString();
                //txtOrder.Text = dgvApartment.Rows[e.RowIndex].Cells[4].Value.ToString();
            }

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.Newdata();
        }
        private void Newdata()
        {
            txtID.Text = "";
            txtLoc.Text = "";
            txtSize.Text = "";
            txtPrice.Text = "";
          
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
            var query = $"delete from Apartment where ApartmentID={id}";
            if (DataAccess.ExecuteQuery(query) == false)
                return;
            MessageBox.Show("Deleted");
            this.LoadData();
            this.Newdata();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            string loc = txtLoc.Text;
            string size = txtSize.Text;
            string price = txtPrice.Text;
            
            string query = "";
            if (id == "")

            {
                query =$"insert into Apartment(Location, Size, Price) values('{loc}', '{size}', '{price}')";


            }
            else
            {
                query = $"update Apartment set Location='{loc}', Size='{size}',Price={price} where ApartmentID={id}";


            }
            if (DataAccess.ExecuteQuery(query) == false)
                return;
            MessageBox.Show("Operation completed");
            this.LoadData();
            this.Newdata();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminDashboard ad = new AdminDashboard();
            ad.Show();
            this.Hide();
        }
    }
}
        
    

