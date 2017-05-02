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

namespace HotelDatabaseAssessment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //test line below
            Connection.ConnectionString = DBCalls.Connection;
            Command.Connection = Connection;
        }

        /// <summary>
        /// the below is test code
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        

        private SqlCommand Command = new SqlCommand();
        private SqlConnection Connection = new SqlConnection();
        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            //I can throw this code anywhere, but currently it is hard coded...
            using (SqlCommand testAddRecord=new SqlCommand(DBCalls.AddRecordMovie, Connection))
            {
                testAddRecord.Parameters.AddWithValue("@Rating", "T");
                testAddRecord.Parameters.AddWithValue("@Title", "Test");
                testAddRecord.Parameters.AddWithValue("@Year", "33333");
                testAddRecord.Parameters.AddWithValue("@Rental_Cost", "30.30");
                testAddRecord.Parameters.AddWithValue("@Plot", "The first of many tests");
                testAddRecord.Parameters.AddWithValue("@Genre", "Test");
                Connection.Open();
                testAddRecord.ExecuteNonQuery();
                Connection.Close();
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            using (SqlCommand testAddRecord = new SqlCommand(DBCalls.AddRecordCustomer, Connection))
            {
                testAddRecord.Parameters.AddWithValue("@FirstName", "Testy");
                testAddRecord.Parameters.AddWithValue("@LastName", "Mc Test");
                testAddRecord.Parameters.AddWithValue("@Address", "123 Fake Street");
                testAddRecord.Parameters.AddWithValue("@Phone", "33333");

                Connection.Open();
                testAddRecord.ExecuteNonQuery();
                Connection.Close();
            }
        }
    }
}
