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
    public partial class FormNewMovie : Form
    {
        public FormNewMovie()
        {
            InitializeComponent();
            Connection.ConnectionString = DBCalls.Connection;
            Command.Connection = Connection;
        }
        private SqlCommand Command = new SqlCommand();
        private SqlConnection Connection = new SqlConnection();

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            double exceptionThrower;//same idea as new customer form
            try
            {
                exceptionThrower = Convert.ToDouble(txtRental_Cost.Text);
                exceptionThrower = Convert.ToDouble(txtYear.Text);
            }
            catch
            {
                exceptionThrower = -2;
            }
            bool filledOut = exceptionThrower > -2;//same idea as new customer form
            foreach (TextBox field in Controls.OfType<TextBox>())
            {
                filledOut = filledOut && !string.IsNullOrEmpty(field.Text);
            }
            if (filledOut)
            {
                using (SqlCommand c = new SqlCommand(DBCalls.AddRecordMovie, Connection))
                {
                    c.Parameters.AddWithValue("@Rating", txtRating.Text);
                    c.Parameters.AddWithValue("@Title", txtTitle.Text);
                    c.Parameters.AddWithValue("@Year", txtYear.Text);
                    c.Parameters.AddWithValue("@Rental_Cost", txtRental_Cost.Text);
                    c.Parameters.AddWithValue("@Plot", txtPlot.Text);
                    c.Parameters.AddWithValue("@Genre", txtGenre.Text);
                    Connection.Open();
                    c.ExecuteNonQuery();
                    Connection.Close();
                }
                this.Hide();
                MessageBox.Show(Resources.Movie_Added_Successfully);
                foreach (TextBox field in Controls.OfType<TextBox>())
                {
                    field.Text = null;
                }
                this.Close();
            }
            else//if-else is needed, because the form still exists when it is closed
            {
                MessageBox.Show(Resources.Missing_field+Resources.Movie_missing_field_part_two);
            }
        }
    }
}
