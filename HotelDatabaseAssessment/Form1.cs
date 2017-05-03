using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelDatabaseAssessment
{
    /// <summary>
    /// This is the main menu form
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //test line below
            Connection.ConnectionString = DBCalls.Connection;
            Command.Connection = Connection;
        }



        
            //these two lines (and the methods done upon button presses) should not be on the form, they should be in the Data class //todo:MAKE DATA CLASS
        private SqlCommand Command = new SqlCommand();
        private SqlConnection Connection = new SqlConnection();
        public FormNewCustomer AddCustomer = new FormNewCustomer();
        public FormNewMovie AddMovie = new FormNewMovie();
        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            AddMovie.ShowDialog();
        }

        

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomer.ShowDialog();
        }
    }
}
