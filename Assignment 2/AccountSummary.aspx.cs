//Tony Piccirilli
//Assignment 2
//November 13, 2017
//CIS 411
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Assignment_2.MyClasses;

namespace Assignment_2
{
    public partial class AccountSummary : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {            

            GenerateSessionObjects accountList = new GenerateSessionObjects();
            var customer = accountList.GenerateCustomer();
            foreach (var acct in accountList.GenerateAccounts())
            {
                AccountListBox.Items.Add(acct.Nickname);
                if (Session[$"{acct.Nickname}Nickname"] == null)  //Make sure a list item is selectd
                {
                    Session[$"{acct.Nickname}Nickname"] = acct.Nickname;
                    Session[$"{acct.Nickname}Balance"] = acct.Balance;
                    Session[$"{acct.Nickname}Type"] = acct.Type;  // Find all objects associated with item
                    Session[acct.Nickname] = acct;
                    Session[$"{acct.Nickname}FullName"] = customer.FullName;
                    Session[$"{acct.Nickname}FullAddress"] = customer.FullAddress;
                }

            }
            

            NameLabel.Text = "Welcome " + customer.FullName;  //add Name to the label
            
           
         
        }

        protected void DetailsButton_Click(object sender, EventArgs e)
        {
            Server.Transfer("AccountPages/AccountDetails.aspx");  //Once button is clicked send to new page
        }

        protected void AccountListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var pi = sender.GetType().GetProperty("Text");
            var temp = (string)(pi.GetValue(sender, null));  //find selected list item
            Session["SelectedAccount"] = temp;
        }
    }
}