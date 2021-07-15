using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace AddressBookUsingLinq
{
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
            Console.Write("\nEnter the first name  : ");
            string firstName = Console.ReadLine();
            Console.Write("\nEnter the last name : ");
            string lastName = Console.ReadLine();
            Console.Write("\nEnter the address : ");
            string address = Console.ReadLine();
            Console.Write("\nEnter the city : ");
            string city = Console.ReadLine();
            Console.Write("\nEnter the state  : ");
            string state = Console.ReadLine();
            Console.Write("\nEnter the zip code : ");
            int zipcode = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter the phone number : ");
            long phonenumber = Convert.ToInt64(Console.ReadLine());
            Console.Write("\nEnter the email id : ");
            string emailId = Console.ReadLine();
            dt.Rows.Add(firstName, lastName, address, city, state, zipcode, phonenumber, emailId);
            Console.WriteLine("Contact details added successfully");
        }
    }
}

        

    

