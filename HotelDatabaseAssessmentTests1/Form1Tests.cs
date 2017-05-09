using Microsoft.VisualStudio.TestTools.UnitTesting;
using HotelDatabaseAssessment;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelDatabaseAssessment.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        Form1 myForm=new Form1();


        [TestMethod()]
        public void LoadCustomersReturnsDataTableTest()
        {
           
                var expected = new DataTable();

                var actual = myForm.LoadCustomers();
          Assert.IsInstanceOfType(actual,expected.GetType());
        }
    }
}