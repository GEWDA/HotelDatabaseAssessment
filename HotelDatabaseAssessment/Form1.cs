﻿using HotelDatabaseAssessment.Properties;
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
    /// This is the main form
    /// </summary>
    public partial class Form1 : Form
    {
        //SETUP
        public Form1()
        {
            InitializeComponent();
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


        //EVENTS

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

        private void AnyDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridView theDG = (DataGridView)sender;  //while the sender will always be a DataGridView,
                if (sender == DGCustomer)                   //sender type must be object due to this being an event
                {
                    lblCustID.Text = theDG.Rows[e.RowIndex].Cells[0].Value.ToString();
                    txtFirstName.Text = theDG.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtLastName.Text = theDG.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txtAddress.Text = theDG.Rows[e.RowIndex].Cells[3].Value.ToString();
                    txtPhone.Text = theDG.Rows[e.RowIndex].Cells[4].Value.ToString();
                }
                else if (sender == DGMovies)
                {
                    lblMovieID.Text = theDG.Rows[e.RowIndex].Cells[0].Value.ToString();
                    txtRating.Text = theDG.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtTitle.Text = theDG.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txtYear.Text = theDG.Rows[e.RowIndex].Cells[3].Value.ToString();
                    txtRentalCost.Text = theDG.Rows[e.RowIndex].Cells[4].Value.ToString();
                    txtCopies.Text = theDG.Rows[e.RowIndex].Cells[5].Value.ToString();
                    txtPlot.Text = theDG.Rows[e.RowIndex].Cells[6].Value.ToString();
                    txtGenre.Text = theDG.Rows[e.RowIndex].Cells[7].Value.ToString();
                }                
            }
            catch
            {
                
            }
        }
        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            using (SqlCommand update = new SqlCommand(DBCalls.UpdateCustomers, Connection))
            {
                try
                {
                    update.Parameters.AddWithValue("@CustID", lblCustID.Text);
                    update.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                    update.Parameters.AddWithValue("@LastName", txtLastName.Text);
                    update.Parameters.AddWithValue("@Address", txtAddress.Text);
                    update.Parameters.AddWithValue("@Phone", txtPhone.Text);

                    Connection.Open();
                    update.ExecuteNonQuery();
                    Connection.Close();
                    MessageBox.Show(Resources.Customer_Added_Successfully);//By using MessageBox, I cause the Form1_Activated event to run again, refreshing the DataGrids
                }
                catch
                {
                    MessageBox.Show(Resources.Missing_field);
                }

            }
        }
        private void btnUpdateMovie_Click(object sender, EventArgs e)
        {
            using (SqlCommand update = new SqlCommand(DBCalls.UpdateMovies, Connection))
            {
                try
                {
                    update.Parameters.AddWithValue("@MovieID", lblMovieID.Text);
                    update.Parameters.AddWithValue("@Rating", txtRating.Text);
                    update.Parameters.AddWithValue("@Title", txtTitle.Text);
                    update.Parameters.AddWithValue("@Year", txtYear.Text);
                    update.Parameters.AddWithValue("@Rental_Cost", txtRentalCost.Text);
                    update.Parameters.AddWithValue("@Copies", txtCopies.Text);
                    update.Parameters.AddWithValue("@Plot", txtPlot.Text);
                    update.Parameters.AddWithValue("@Genre", txtGenre.Text);

                    Connection.Open();
                    update.ExecuteNonQuery();
                    Connection.Close();
                    MessageBox.Show(Resources.Movie_Added_Successfully);
                }
                catch
                {
                    MessageBox.Show(Resources.Missing_field);
                }

            }
        }

        private void btnRentMovie_Click(object sender, EventArgs e)
        {
            FormRentMovie rentMovie = new FormRentMovie(GetMovieInfo());
            rentMovie.ShowDialog();
        }
        //METHODS


        public DataTable[] LoadAllDG()
        {
            try
            {
                Connection.Close();//If something else encounters and error (e.g. if you put a REALLY big number in the phone field of the customer form), the connection can occasionally be left open
            }
            catch
            {

            }
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
            if(!RentedMoviesTable.Columns.Contains("RMID"))//i.e. If you haven't already set up the Columns, then set up the columns
            {
                RentedMoviesTable.Columns.Add("RMID");
                RentedMoviesTable.Columns.Add("FirstName");
                RentedMoviesTable.Columns.Add("LastName");
                RentedMoviesTable.Columns.Add("Address");
                RentedMoviesTable.Columns.Add("Title");
                RentedMoviesTable.Columns.Add("Rental_Cost");
                RentedMoviesTable.Columns.Add("DateRented");
                RentedMoviesTable.Columns.Add("DateReturned");
            }

            using (SqlCommand c = new SqlCommand(DBCalls.LoadRentedMoviesDG, Connection))
            {
                Connection.Open();
                SqlDataReader r = c.ExecuteReader();
                while (r.Read())
                {
                    RentedMoviesTable.Rows.Add(r["RMID"], r["FirstName"], r["LastName"], r["Address"], r["Title"], r["Rental_Cost"], r["DateRented"], r["DateReturned"]);
                }
                r.Close();
                Connection.Close();
                return RentedMoviesTable;
            }
        }

        private DataTable LoadMovies()
        {
            MoviesTable.Clear();
            if(!MoviesTable.Columns.Contains("MovieID"))
            {
                MoviesTable.Columns.Add("MovieID");
                MoviesTable.Columns.Add("Rating");
                MoviesTable.Columns.Add("Title");
                MoviesTable.Columns.Add("Year");
                MoviesTable.Columns.Add("Rental_Cost");
                MoviesTable.Columns.Add("Copies");
                MoviesTable.Columns.Add("Plot");
                MoviesTable.Columns.Add("Genre");
            }

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
            if(!CustomerTable.Columns.Contains("CustID"))
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


        /// <summary>
        /// Extracts the currently selected Movie record to a string array
        /// </summary>
        /// <returns>a string array with all info from one record in DGMovies</returns>
        private string[] GetMovieInfo()
        {
            string[] array = new string[] { lblMovieID.Text,txtRating.Text,txtTitle.Text,txtYear.Text,txtRentalCost.Text,txtCopies.Text,txtPlot.Text,txtGenre.Text};
            return array;
        }

        private DataTable LoadUnreturned()
        {
            Unreturned.Clear();
            if(!Unreturned.Columns.Contains("RMID"))
            {
                Unreturned.Columns.Add("RMID");
                Unreturned.Columns.Add("FirstName");
                Unreturned.Columns.Add("LastName");
                Unreturned.Columns.Add("Address");
                Unreturned.Columns.Add("Title");
                Unreturned.Columns.Add("Rental_Cost");
                Unreturned.Columns.Add("DateRented");
                Unreturned.Columns.Add("DateReturned");
            }

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
