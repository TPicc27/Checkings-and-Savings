//Tony Piccirilli
//Assignment 2
//November 13, 2017
//CIS 411
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment_2.MyClasses
{
    public class GenerateSessionObjects
    {
        List<Account> Accounts = new List<Account>();
        
        public List<Account> GenerateAccounts()
        {           
            Accounts.Add(new Account("Checking", 26970, "My Chk1"));
            Accounts.Add(new Account("Checking", 34586, "My Chk2"));  //Adding new list items to account list
            Accounts.Add(new Account("Saving", 40003, "My Sav1"));
           

            return Accounts;
        }


        public Customer GenerateCustomer()
        {
           return new Customer("Tony Piccirilli", "1 Cardinal Way"); //Creating new customer object
        }
    }
}