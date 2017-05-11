using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelDatabaseAssessment
{
    /// <summary>
    /// Contains all of the static sql commands for this solution
    /// </summary>
    public static class DBCalls
    {
        //CONNECTION STRING TO DATABASE
        //note that upon changing computers, the Data Source will need to change from 'LAPTOP-OUSE04QM\SQLEXPRESS' to wherever the server is located
        public static string Connection { get; set; }
            = @"Data Source=LAPTOP-OUSE04QM\SQLEXPRESS;Initial Catalog=VBMoviesFullData;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        //most of these are self explanatory

        //UPDATES
        public static string UpdateCustomers { get; set; }
            = @"UPDATE Customer SET FirstName=@FirstName, LastName=@LastName, Address=@Address, Phone=@Phone WHERE CustID=@CustID";
        public static string UpdateMovies { get; set; }
            = @"UPDATE Movies SET Rating=@Rating, Title=@Title, Year=@Year, Rental_Cost=@Rental_Cost, Copies=@Copies, Plot=@Plot, Genre=@Genre WHERE MovieID=@MovieID";
        public static string UpdateMoviesRentalCost { get; set; }
            = @"UPDATE Movies SET Rental_Cost=@Rental_Cost WHERE MovieID=@MovieID";
        public static string UpdateRented { get; set; }
            = @"UPDATE RentedMovies SET DateReturned=@DateReturned WHERE RMID=@RMID";

        //LOADING DATAGRIDS (doesn't load 'deleted' records)
        public static string LoadCustomerDG { get; set; }
            = @"SELECT CustID,FirstName,LastName,Address,Phone FROM Customer WHERE (IsDeleted=0) ORDER by CustID";
        public static string LoadMoviesDG { get; set; }
            = @"SELECT MovieID,Rating,Title,Year,Rental_Cost,Copies,Plot,Genre FROM Movies WHERE (IsDeleted=0) ORDER by MovieID";
        public static string LoadRentedMoviesDG { get; set; }
            = @"SELECT * FROM CustomerAndMoviesRented ORDER by RMID";

        public static string LoadUnreturnedDG { get; set; }
            = @"SELECT * FROM CustomerAndMoviesRented WHERE DateReturned IS NULL";

        //ADD NEW RECORDS
        public static string AddRecordCustomer { get; set; }
            = @"INSERT INTO Customer (FirstName, LastName, Address, Phone) VALUES ( @FirstName, @LastName, @Address, @Phone)";
        public static string AddRecordMovie { get; set; }
            = @"INSERT INTO Movies (Rating, Title, Year, Rental_Cost, Plot, Genre) VALUES ( @Rating, @Title, @Year, @Rental_Cost, @Plot, @Genre)";

        public static string AddRecordRented { get; set; }
            = @"INSERT INTO RentedMovies (MovieIDFK, CustIDFK, DateRented) VALUES (@MovieID, @CustID, @DateRented)";//note that the FK variants have the actual ID values

        //'DELETE' RECORDS
        //(actually sets "IsDeleted" to 1, meaning they won't load into the Customer or Movie DataGrid,
        //but relevant records from the sales history (RentedMovies table and Unreturned view) will still exist without trouble)
        public static string DeleteRecordCustomer { get; set; }
            = @"UPDATE Customer SET IsDeleted=1 WHERE CustID=@CustID";
        public static string DeleteRecordMovie { get; set; }
            = @"UPDATE Movies SET IsDeleted=1 WHERE MovieID=@MovieID";
    }
}
