using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace AddressBookUsingLinq
{
    /// <summary>
    /// creating the data table using linq properies we insert all data
    /// </summary>
    public class AddressBooks
    {
        //UC1:create table
        DataTable dt = new DataTable();
        public void CreateTable()
        {            
            //UC2:add columns to table
            dt.Columns.Add("firstName", typeof(string));
            dt.Columns.Add("lastName", typeof(string));
            dt.Columns.Add("Address", typeof(string));
            dt.Columns.Add("city", typeof(string));
            dt.Columns.Add("state", typeof(string));
            dt.Columns.Add("zipcode", typeof(int));
            dt.Columns.Add("phonenumber", typeof(long));
            dt.Columns.Add("emailId", typeof(string));

        }
        /// <summary>
        /// UC3:inserting data to table
        /// </summary>
        public void InsertRows()
        {            
            dt.Rows.Add("Akhila", "Reddy", "Balaji nagr", "Delhi", "Ap", 509132, 8678906541, "akhila@gmail.com");
            dt.Rows.Add("Sushma", "Bargavi", "X-nagar", "gadwal", "Mumbai", 590345, 9087654321, "Bargavai@gmail.com");
            dt.Rows.Add("navin", "Chandra", "Y-nagar", "hyd", "Maharastra", 509234, 7896543210, "akhi@gmail.com");
            Console.WriteLine("Contact details added successfully");
        }
        /// <summary>
        /// display method shows the detilas of contacts in table
        /// </summary>
        public void DisplayContacts()
        {
            foreach (var table in dt.AsEnumerable())
            {
                // Get all field by column index.
                Console.WriteLine("\nFirstName:-" + table.Field<string>("FirstName"));
                Console.WriteLine("LastName:-" + table.Field<string>("LastName"));
                Console.WriteLine("Address:-" + table.Field<string>("Address"));
                Console.WriteLine("City:-" + table.Field<string>("City"));
                Console.WriteLine("State:-" + table.Field<string>("State"));
                Console.WriteLine("ZipCode:-" + table.Field<int>("ZipCode"));
                Console.WriteLine("PhoneNumber:-" + table.Field<long>("PhoneNumber"));
                Console.WriteLine("EmailId:-" + table.Field<string>("EmailId"));
            }
        }
    }
}

        

    

