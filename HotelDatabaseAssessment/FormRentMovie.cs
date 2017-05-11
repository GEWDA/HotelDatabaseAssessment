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
    public partial class FormRentMovie : Form
    {
        public FormRentMovie(string[] movieInfo)
        {
            InitializeComponent();
            Connection.ConnectionString = DBCalls.Connection;
            Command.Connection = Connection;
            SenderData = movieInfo;
        }
        private SqlCommand Command = new SqlCommand();
        private SqlConnection Connection = new SqlConnection();        
        DataTable CustomerTable = new DataTable();

        //PROPERTIES/FIELDS
        public string[] SenderData { get; set; }
        private string[] _selectedCustomer = new string[3];

        //EVENTS
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            using(FormNewCustomer addCustomer = new FormNewCustomer())
            addCustomer.ShowDialog();
        }
        private void FormRentMovie_Activated(object sender, EventArgs e)
        {
            DGCustomer.DataSource = LoadCustomers();//only the Customer DataGrid is needed, so that is all that is loaded
        }
        private void btnRent_Click(object sender, EventArgs e)
        {
            using (SqlCommand addRecord = new SqlCommand(DBCalls.AddRecordRented, Connection))
            {
                try
                {
                    addRecord.Parameters.AddWithValue("@MovieID", SenderData[0]);
                    addRecord.Parameters.AddWithValue("@CustID", _selectedCustomer[0]);
                    addRecord.Parameters.AddWithValue("@DateRented", DateTime.Now.ToString());

                    Connection.Open();
                    addRecord.ExecuteNonQuery();
                    Connection.Close();
                    Hide();
                    MessageBox.Show(_selectedCustomer[1]+" "+_selectedCustomer[2]+" has successfully rented the movie: "+SenderData[2]);
                    Close();
                }
                catch
                {
                    try
                    {
                        Connection.Close();//in case connection is still open
                    }
                    catch
                    {
                        
                    }
                    MessageBox.Show(Resources.Please_Select_A_Record);
                }
            }
        }

        private void DG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView theDG = (DataGridView) sender;
            if(e.RowIndex!=-1)//required to prevent crash when sorting table by a column (e.g. last name)
            {
                _selectedCustomer[0] = theDG.Rows[e.RowIndex].Cells[0].Value.ToString();//required for adding record
                _selectedCustomer[1] = theDG.Rows[e.RowIndex].Cells[1].Value.ToString();//only used for confirmation message
                _selectedCustomer[2] = theDG.Rows[e.RowIndex].Cells[2].Value.ToString();//only used for confirmation message
            }
        }

        //METHODS
        private DataTable LoadCustomers()
        {

            CustomerTable.Clear();
            if (!CustomerTable.Columns.Contains("CustID"))
            {
                CustomerTable.Columns.Add("CustID");
                CustomerTable.Columns.Add("FirstName");
                CustomerTable.Columns.Add("LastName");
                CustomerTable.Columns.Add("Address");
                CustomerTable.Columns.Add("Phone");
            }

            using (SqlCommand c = new SqlCommand(DBCalls.LoadCustomerDG, Connection))
            {
                Connection.Open();
                SqlDataReader r = c.ExecuteReader();
                while (r.Read())
                {
                    CustomerTable.Rows.Add(r["CustID"], r["FirstName"], r["LastName"], r["Address"], r["Phone"]);
                }
                r.Close();
                Connection.Close();
                return CustomerTable;
            }
        }

    }
}
