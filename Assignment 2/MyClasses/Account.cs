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
    public class Account
    {
        public string Type { get; set; }  //type property
        public double Balance { get; set; }  //balance property
        public string Nickname { get; set; } //nickname property

        public Account(string _type, double _balance, string _nickname)  //Constructor
        {
            Type = _type;
            Balance = _balance;
            Nickname = _nickname;
        }

        public bool hasLoanOffer()  //method to make sure loan is accepted
        {
            if(Balance >= 15000)
            {
                return true;  //true if balance is more than 15000
            }
            else
            {
                return false;  //false if balance is more than 15000
            }
        }

        
    }
}