using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace AddressBookUsingLinq
{
    public class AddressBooks
    {
        //create table
        DataTable dt = new DataTable();
        public void CreateTable()
        {
            
            //add columns to table
            dt.Columns.Add("firstName", typeof(string));
            dt.Columns.Add("lastName", typeof(string));
            dt.Columns.Add("Address", typeof(string));
            dt.Columns.Add("city", typeof(string));
            dt.Columns.Add("state", typeof(string));
            dt.Columns.Add("zipcode", typeof(int));
            dt.Columns.Add("phonenumber", typeof(long));

        }
    }
}

        

    

