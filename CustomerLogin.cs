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
    public partial class CustomerLogin : Form
    {
        public CustomerLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string email = txtEmail.Text;
            string password = txtPass.Text;
            if (email == "admin@gmail.com" && password == "admin")
            {
                AdminDashboard ad = new AdminDashboard();
                ad.Show();
                this.Hide();
                return;
            }
            string query = $"select * from Customer where Email = '{email}'and Password = '{password}'";

            var data = DataAccess.GetData(query);
            if (data == null)
                return;
            if (data.Rows.Count != 1)
            {
                MessageBox.Show("Invalid username or password");
                return;

            }
            string cName = data.Rows[0]["CName"].ToString();
            //UserHelper.UserID = int.Parse(data.Rows[0]["CustomerID"].ToString());

            MessageBox.Show("Welcome , " + cName);
            int customerId = int.Parse(data.Rows[0]["CustomerID"].ToString());

            CustomerDashBoard cd = new CustomerDashBoard(customerId);
            cd.Show();
            this.Hide();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            CustomerRegistrationForm frm = new CustomerRegistrationForm();
            frm.Show();
            this.Hide();
        }
    }
}