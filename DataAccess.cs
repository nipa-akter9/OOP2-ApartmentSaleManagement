using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace NewProject
{
    static class DataAccess
    {
        static string _connectionString = "Data Source=MSI;Initial Catalog = Apartmentdb; Integrated Security = True; Encrypt=False";
        public static DataTable GetData(string query)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = _connectionString;
                con.Open();

                SqlCommand cmb = new SqlCommand();
                cmb.Connection = con;
                cmb.CommandText = query;

                SqlDataAdapter adapter = new SqlDataAdapter(cmb);
                DataSet ds = new DataSet();
                adapter.Fill(ds);

                DataTable dt = ds.Tables[0];
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public static bool ExecuteQuery(string query)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = _connectionString;
                con.Open();
                SqlCommand cmb = new SqlCommand();
                cmb.Connection = con;
                cmb.CommandText = query;


                cmb.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
