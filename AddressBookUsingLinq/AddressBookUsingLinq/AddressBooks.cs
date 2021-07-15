using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
                Console.WriteLine("\nFirstName:-" + table.Field<string>("FirstName")+ "\n LastName:-" + table.Field<string>("LastName")+ "\n Address:-" + table.Field<string>("Address")+
                    "\n City:-" + table.Field<string>("City")+ "\n State:-" + table.Field<string>("State")+
                    "\n ZipCode:-" + table.Field<int>("ZipCode")+ "\n PhoneNumber:-" + table.Field<long>("PhoneNumber")+ "\n EmailId:-" + table.Field<string>("EmailId"));
            }
        }
        /// <summary>
        /// UC4-Edit the contact details in address book using linq
        /// </summary>
        public void EditContacts()
        {
            try
            {                
                string editName = "Akhila";
                
                var updateContact = dt.AsEnumerable().Where(x => x.Field<string>("FirstName").Equals(editName)).FirstOrDefault();
                if (updateContact != null)
                {
                    ////Update contacts
                    updateContact.SetField("PhoneNumber", "895478520");
                    updateContact.SetField("City", "Vemula");
                    updateContact.SetField("State", "Maharastra");
                    Console.WriteLine("\n contacts updated successfully!", editName);
                    DisplayContacts();
                }
                else
                {
                    Console.WriteLine("There is no such contacts in the Address Book!");
                }
            }
           
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        /// <summary>
        /// UC5-deleting the row by using name in addresssbook
        /// </summary>
        /// <param name="firstName"></param>
        public void DeleteContacts(string firstName)
        {
            try
            {               
                var Deleterow = dt.AsEnumerable().Where(x => x.Field<string>("FirstName").Equals(firstName)).FirstOrDefault();
                if (Deleterow != null)
                {                   
                    Deleterow.Delete();
                    Console.WriteLine("\nContacts deleted successfully!", firstName);
                    DisplayContacts();
                }
                else
                {
                    Console.WriteLine("There is no such data in address book");
                }
            }            
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        /// <summary>
        /// UC6:retriew data from city in addressbook
        /// </summary>
        public void RetriewDataByCity()
        {
            Contacts contacts = new Contacts();
            var records = dt.AsEnumerable().Where(x => x.Field<string>("City").Equals(contacts.city)).FirstOrDefault();
            foreach (var table in dt.AsEnumerable())
            {
                // Get all field by column index.
                Console.WriteLine("\nFirstName:-" + table.Field<string>("FirstName") + "\n LastName:-" + table.Field<string>("LastName") + "\n Address:-" + table.Field<string>("Address") + 
                    "\n City:-" + table.Field<string>("City") + "\n State:-" + table.Field<string>("State") +
                    "\n ZipCode:-" + table.Field<int>("ZipCode") + "\n PhoneNumber:-" + table.Field<long>("PhoneNumber") + "\n EmailId:-" + table.Field<string>("EmailId"));
            }
        }
        /// <summary>
        /// UC8:sorting addressbook by alphabetically in table usinmg names
        /// </summary>
        public void SortingAlphabetically()
        {
            Contacts contacts = new Contacts();
            var records = dt.AsEnumerable().Where(x => x.Field<string>("City") == contacts.city).OrderBy(x => x.Field<string>("FirstName")).ThenBy(x => x.Field<string>("LastName"));
            foreach (var table in dt.AsEnumerable())
            {
                // Get all field by column index.
                Console.WriteLine("\nFirstName:-" + table.Field<string>("FirstName") + "\n LastName:-" + table.Field<string>("LastName") + "\n Address:-" + table.Field<string>("Address") +
                    "\n City:-" + table.Field<string>("City") + "\n State:-" + table.Field<string>("State") +
                    "\n ZipCode:-" + table.Field<int>("ZipCode") + "\n PhoneNumber:-" + table.Field<long>("PhoneNumber") + "\n EmailId:-" + table.Field<string>("EmailId"));
            }
        }
    }
}

        

    

