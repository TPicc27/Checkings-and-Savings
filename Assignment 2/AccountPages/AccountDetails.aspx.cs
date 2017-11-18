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

namespace Assignment_2.AccountPages
{
    public partial class AccountDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var passedInNickname = Session["SelectedAccount"];

            var sessionNickname = Session[$"{passedInNickname}Nickname"].ToString();
            var sessionBalance = Session[$"{passedInNickname}Balance"].ToString();
            var sessionType = Session[$"{passedInNickname}Type"].ToString();

            AcctTypeLabel.Text = sessionType.ToString();
            BalanceLabel.Text = sessionBalance.ToString();
            AccountNameLabel.Text = sessionNickname.ToString();
            
            var account = new Account(sessionType, double.Parse(sessionBalance), sessionNickname);

            var hasLoanOffer = account.hasLoanOffer();

            LoanLabel.Text = hasLoanOffer.ToString();

            AddressLabel.Text = Session[$"{passedInNickname}FullAddress"].ToString();

        }

        protected void WithdrawButton_Click(object sender, EventArgs e)
        {
            if (double.Parse(WithdrawTB.Text) <= double.Parse(BalanceLabel.Text))
            {
                var amount = WithdrawTB.Text;

                var passedInNickname = Session["SelectedAccount"];
                var sessionBalance = Session[$"{passedInNickname}Balance"].ToString();

                var newbalance = double.Parse(sessionBalance) - double.Parse(amount);

                BalanceLabel.Text = newbalance.ToString();

                Session[$"{passedInNickname}Balance"] = newbalance.ToString();
                WithdrawTB.Text = "";
            }
            else
            {
                WithdrawErrorLabel.Text = "Withdraw Amount is greater than the Balance.";
            }
            

        }
    }
}