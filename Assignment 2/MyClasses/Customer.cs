using System;
//Tony Piccirilli
//Assignment 2
//November 13, 2017
//CIS 411
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment_2.MyClasses
{
    public class Customer
    {
        public string FullName { get; }
        public string FullAddress { get; }

        public Customer(string names, string address)
        {
            FullName = names;
            FullAddress = address;
        }
    }
}