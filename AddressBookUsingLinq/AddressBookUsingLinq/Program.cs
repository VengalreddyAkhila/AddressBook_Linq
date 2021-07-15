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
            addressBooks.CreateTable();
            addressBooks.InsertRows();
        }
    }
}
