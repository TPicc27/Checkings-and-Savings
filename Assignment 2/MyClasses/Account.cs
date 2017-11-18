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
        public string Type { get; set; }
        public double Balance { get; set; }
        public string Nickname { get; set; }

        public Account(string _type, double _balance, string _nickname)
        {
            Type = _type;
            Balance = _balance;
            Nickname = _nickname;
        }

        public bool hasLoanOffer()
        {
            if(Balance >= 15000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        
    }
}