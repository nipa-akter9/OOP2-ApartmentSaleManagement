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
    public partial class CustomerDashBoard: Form
    {
        int customerId;
        public CustomerDashBoard(int customerId)
        {
            InitializeComponent();
            this.customerId = customerId;
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            CustomerView cv = new CustomerView(customerId);
            cv.Show();
            this.Hide();
        }

        private void btnMOrder_Click(object sender, EventArgs e)
        {
            MyOrder mo = new MyOrder(customerId);
            mo.Show();
            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            CustomerLogin cl = new CustomerLogin();
            cl.Show();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPayHistory_Click(object sender, EventArgs e)
        {
            PaymentHistory paymentHistory = new PaymentHistory();
            paymentHistory.Show();
            this.Hide();
        }
    }
}
