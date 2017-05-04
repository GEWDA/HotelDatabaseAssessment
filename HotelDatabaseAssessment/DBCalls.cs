using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelDatabaseAssessment
{
    static class DBCalls
    {
        public static string Connection { get; set; }
            = @"Data Source=LAPTOP-OUSE04QM\SQLEXPRESS;Initial Catalog=VBMoviesFullData;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public static string UpdateCustomers { get; set; }
            = @"UPDATE Customer set FirstName=@FirstName, LastName=@LastName, Address=@Address, Phone=@Phone where CustID=@CustID";
        public static string UpdateMovies { get; set; }
            = @"UPDATE Movies set Rating=@Rating, Title=@Title, Year=@Year, Rental_Cost=@Rental_Cost, Copies=@Copies, Plot=@Plot, Genre=@Genre where MovieID=@MovieID";
        public static string UpdateRented { get; set; }
            = @"UPDATE RentedMovies set MovieIDFK=@MovieIDFK, CustIDFK=@CustIDFK, DateRented=@DateRented, DateReturned=@DateReturned where RMID=@RMID";

        //public static string LoadViews { get; set; }
        //    = @"SELECT Customer.*, Movies.*, RentedMovies.* FROM Customer INNER JOIN RentedMovies ON Customer.CustID = RentedMovies.CustIDFK INNER JOIN Movies ON RentedMovies.MovieIDFK = Movies.MovieID";

        public static string LoadCustomerDG { get; set; }
            = @"SELECT * FROM Customer ORDER by CustID";
        public static string LoadMoviesDG { get; set; }
            = @"SELECT * FROM Movies ORDER by MovieID";
        public static string LoadRentedMoviesDG { get; set; }
            = @"SELECT * FROM RentedMovies ORDER by RMID";

        public static string LoadUnreturnedDG { get; set; }
            = @"SELECT * FROM CustomerAndMoviesRented WHERE DateReturned IS NULL";

        public static string AddRecordCustomer { get; set; }
            = "INSERT INTO Customer (FirstName, LastName, Address, Phone) VALUES ( @FirstName, @LastName, @Address, @Phone)";
        public static string AddRecordMovie { get; set; }
            = "INSERT INTO Movies (Rating, Title, Year, Rental_Cost, Plot, Genre) VALUES ( @Rating, @Title, @Year, @Rental_Cost, @Plot, @Genre)";

        public static string AddRecordRented { get; set; } //todo:this
            = "INSERT INTO RentedMovies (MovieIDFK, CustIDFK, DateRented, DateReturned) VALUES (@MovieID, @CustID, @DateRented, @DateReturned)";//note that the FK variants have the actual ID values

        public static string DeleteRecordCustomer { get; set; }//todo:these
            = "DELETE Customer WHERE CustID=@CustID";
        public static string DeleteRecordMovie { get; set; }
            = "DELETE Movies WHERE MovieID=@MovieID";

        //public static string DeleteRecordRented { get; set; }     //actually, I never want to do this. I will always want the sales history
        //    = "DELETE RentedMovies WHERE RMID=@RMID";
    }
}
