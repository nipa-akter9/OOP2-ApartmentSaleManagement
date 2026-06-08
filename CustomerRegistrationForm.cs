using NewProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApartmentSaleManagement
{
    public partial class CustomerRegistrationForm: Form
    {
        public CustomerRegistrationForm()
        {
            InitializeComponent();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            txtPass.PasswordChar = '\0';
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            txtPass.PasswordChar = '#';
        }
        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            if (txtPass.Text.Length < 8)
            {
                lblError.Visible = true;
                lblError.Text = "More than 8 Character";
                return;
            }

            if (txtPass.Text == "" || txtCPass.Text == "")
            {
                lblError.Visible = false;
                lblError.Text = "";
                return;
            }

            if (txtPass.Text != txtCPass.Text)
            {
                lblError.Visible = true;
                lblError.Text = "Does Not Match";
            }
            else
            {
                lblError.Visible = false;
                lblError.Text = "";
            }
        }

        private void txtCPass_TextChanged(object sender, EventArgs e)
        {
            if (txtPass.Text.Length < 8)
            {
                lblError.Visible = true;
                lblError.Text = "More than 8 Character";
                return;
            }

            if (txtPass.Text == "" || txtCPass.Text == "")
            {
                lblError.Visible = false;
                lblError.Text = "";
                return;
            }

            if (txtPass.Text != txtCPass.Text)
            {
                lblError.Visible = true;
                lblError.Text = "Does Not Match";
            }
            else
            {
                lblError.Visible = false;
                lblError.Text = "";
            }
        }
 private void CustomerRegistrationForm_Load(object sender, EventArgs e)
        {
            lblError.Text = "";
            lblError.Visible = false;
            txtPass.PasswordChar = '#';
            txtCPass.PasswordChar = '#';
        }


        private void btnReg_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            if (name == "")
            {
                MessageBox.Show("Invalid Name");
                txtName.Focus();
                return;
            }

            string email = txtEmail.Text;
            if (email == "")
            {
                MessageBox.Show("Invalid Email");
                txtEmail.Focus();
                return;
            }
        

            string phone = txtPhone.Text;
            if (phone == "")
            {
                MessageBox.Show("Invalid Phone");
                txtPhone.Focus();
                return;
            }

            if (lblError.Visible == true)
            {
                MessageBox.Show(lblError.Text);
                txtPass.Focus();
                return;
            }

            string password = txtPass.Text;

            try
            {
                string insert =  $"INSERT INTO Customer (CName, Email, Phone, Password) " +
                                   $"VALUES ('{name}', '{email}', '{phone}', '{password}')";

                if (DataAccess.ExecuteQuery(insert) == true)
                {
                    MessageBox.Show("Registered Successfully");
                }
                CustomerLogin cl = new CustomerLogin();
                cl.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       
        }
    }
    

