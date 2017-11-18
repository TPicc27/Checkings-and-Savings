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
        public string FullName { get; }  //name property
        public string FullAddress { get; } //address property

        public Customer(string names, string address)  //constructor
        {
            FullName = names;
            FullAddress = address;
        }
    }
}