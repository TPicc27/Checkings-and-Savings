using System;
using System.Collections.Generic;
using System.Linq;
//Tony Piccirilli
//Assignment 2
//November 13, 2017
//CIS 411
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_2.AccountPages
{
    public partial class LoadApplicationPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var passedInNickname = Session["SelectedAccount"];  //find account

            YourNameLabel.Text = Session[$"{passedInNickname}FullName"].ToString();  //show customer name in label
        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            var passedInNickname = Session["SelectedAccount"];
            var sessionBalance = Session[$"{passedInNickname}Balance"].ToString();
            if(double.Parse(AgeTB.Text) >= 18 && double.Parse(sessionBalance) >= double.Parse(LoanTB.Text) && double.Parse(LoanTB.Text) < .5 * double.Parse(SalaryTB.Text))
            {
                LoanApprovalLoan.Text = "Congrualations!! Your loan is approved.";  //if loan is approved
            }
            else
            {
                LoanApprovalLoan.Text = "Your loan is not approved. Sorry!!";  //if loan is declined
            }
        }
    }
}