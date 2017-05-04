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



        
        
        private SqlCommand Command = new SqlCommand();
        private SqlConnection Connection = new SqlConnection();
        public FormNewCustomer AddCustomer = new FormNewCustomer();
        public FormNewMovie AddMovie = new FormNewMovie();
        DataTable CustomerTable=new DataTable();
        DataTable MoviesTable = new DataTable();
        DataTable RentedMoviesTable = new DataTable();
        DataTable Unreturned = new DataTable();

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            AddMovie.ShowDialog();
        }

        

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomer.ShowDialog();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            var DGArray = LoadAllDG();
            DGCustomer.DataSource = DGArray[0];
            DGMovies.DataSource = DGArray[1];
            DGRentedMovies.DataSource = DGArray[2];
            DGUnreturned.DataSource = DGArray[3];
        }

        public DataTable[] LoadAllDG()
        {
            DataTable[] DGArray = new DataTable[4];
            DGArray[0] = LoadCustomers();
            DGArray[1] = LoadMovies();
            DGArray[2] = LoadRentedMovies();
            DGArray[3] = LoadUnreturned();
            return DGArray;

        }

        private DataTable LoadRentedMovies()
        {
            RentedMoviesTable.Clear();
            RentedMoviesTable.Columns.Add("RMID");
            RentedMoviesTable.Columns.Add("MovieIDFK");
            RentedMoviesTable.Columns.Add("CustIDFK");
            RentedMoviesTable.Columns.Add("DateRented");
            RentedMoviesTable.Columns.Add("DateReturned");
            using (SqlCommand c = new SqlCommand(DBCalls.LoadRentedMoviesDG, Connection))
            {
                Connection.Open();
                SqlDataReader r = c.ExecuteReader();
                while (r.Read())
                {
                    RentedMoviesTable.Rows.Add(r["RMID"], r["MovieIDFK"], r["CustIDFK"], r["DateRented"], r["DateReturned"]);
                }
                r.Close();
                Connection.Close();
                return RentedMoviesTable;
            }
        }

        private DataTable LoadMovies()
        {
            MoviesTable.Clear();
            MoviesTable.Columns.Add("MovieID");
            MoviesTable.Columns.Add("Rating");
            MoviesTable.Columns.Add("Title");
            MoviesTable.Columns.Add("Year");
            MoviesTable.Columns.Add("Rental_Cost");
            MoviesTable.Columns.Add("Copies");
            MoviesTable.Columns.Add("Plot");
            MoviesTable.Columns.Add("Genre");
            using (SqlCommand c = new SqlCommand(DBCalls.LoadMoviesDG, Connection))
            {
                Connection.Open();
                SqlDataReader r = c.ExecuteReader();
                while (r.Read())
                {
                    MoviesTable.Rows.Add(r["MovieID"], r["Rating"], r["Title"], r["Year"], r["Rental_Cost"], r["Copies"], r["Plot"], r["Genre"]);
                }
                r.Close();
                Connection.Close();
                return MoviesTable;
            }
        }

        private DataTable LoadCustomers()
        {
            CustomerTable.Clear();
            CustomerTable.Columns.Add("CustID");
            CustomerTable.Columns.Add("FirstName");
            CustomerTable.Columns.Add("LastName");
            CustomerTable.Columns.Add("Address");
            CustomerTable.Columns.Add("Phone");
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

        private DataTable LoadUnreturned()
        {
            Unreturned.Clear();
            Unreturned.Columns.Add("RMID");
            Unreturned.Columns.Add("FirstName");
            Unreturned.Columns.Add("LastName");
            Unreturned.Columns.Add("Address");
            Unreturned.Columns.Add("Title");
            Unreturned.Columns.Add("Rental_Cost");
            Unreturned.Columns.Add("DateRented");
            Unreturned.Columns.Add("DateReturned");
            using (SqlCommand c = new SqlCommand(DBCalls.LoadUnreturnedDG, Connection))
            {
                Connection.Open();
                SqlDataReader r = c.ExecuteReader();
                while (r.Read())
                {
                    Unreturned.Rows.Add(r["RMID"], r["FirstName"], r["LastName"], r["Address"], r["Title"], r["Rental_Cost"], r["DateRented"], r["DateReturned"]);
                }
                r.Close();
                Connection.Close();
                return Unreturned;
            }
        }
    }
}
