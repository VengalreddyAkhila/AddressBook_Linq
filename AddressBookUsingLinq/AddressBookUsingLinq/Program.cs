using System;
using System.Data;

namespace AddressBookUsingLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to Addressbook ");
            AddressBooks addressBooks = new AddressBooks();
            Contacts contacts = new Contacts();
            addressBooks.CreateTable();
            //inserting data to table
            addressBooks.InsertRows();
            addressBooks.DisplayContacts();
            //deleting data in table
            addressBooks.DeleteContacts("Akhila");
            //retriew data from city in table
            Console.WriteLine("Enter city:");
            contacts.city = Console.ReadLine();
            addressBooks.RetriewDataByCity();

        }
    }
}
