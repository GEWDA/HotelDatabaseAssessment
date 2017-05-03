using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelDatabaseAssessment.Properties;

namespace HotelDatabaseAssessment
{
    public partial class FormNewCustomer : Form
    {
        public FormNewCustomer()
        {
            InitializeComponent();
            Connection.ConnectionString = DBCalls.Connection;
            Command.Connection = Connection;
        }
        private SqlCommand Command = new SqlCommand();
        private SqlConnection Connection = new SqlConnection();

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            long exceptionThrower;
            try
            {
                exceptionThrower = Convert.ToInt64(txtPhone.Text);
            }
            catch
            {
                exceptionThrower = -1;
            }
            bool filledOut = exceptionThrower!=-1;
            foreach (TextBox field in Controls.OfType<TextBox>())
            {
                filledOut = filledOut && !string.IsNullOrEmpty(field.Text);
            }
            if (filledOut)
            {
                using (SqlCommand c = new SqlCommand(DBCalls.AddRecordCustomer, Connection))
                {
                    c.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                    c.Parameters.AddWithValue("@LastName", txtLastName.Text);
                    c.Parameters.AddWithValue("@Address", txtAddress.Text);
                    c.Parameters.AddWithValue("@Phone", txtPhone.Text);

                    Connection.Open();
                    c.ExecuteNonQuery();
                    Connection.Close();
                }
                this.Hide();
                MessageBox.Show(Resources.Customer_Added_Successfully);
                foreach (TextBox field in Controls.OfType<TextBox>())
                {
                    field.Text = null;
                }
                this.Close();
            }
            else//else is needed, because the form still exists when it is closed
            {
                MessageBox.Show(Resources.Missing_field+Resources.Customer_missing_field_part_two);
            }
        }
    }
}
