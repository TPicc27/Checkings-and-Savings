<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoadApplicationPage.aspx.cs" Inherits="Assignment_2.AccountPages.LoadApplicationPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 270px;
        }
        .auto-style3 {
            width: 330px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">Name:</td>
                <td class="auto-style3">
                    <asp:Label ID="YourNameLabel" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Salary</td>
                <td class="auto-style3">
                    <asp:TextBox ID="SalaryTB" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Age</td>
                <td class="auto-style3">
                    <asp:TextBox ID="AgeTB" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Loan Amount</td>
                <td class="auto-style3">
                    <asp:TextBox ID="LoanTB" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="SubmitButton" runat="server" Text="Submit" Width="209px" OnClick="SubmitButton_Click"  />
                </td>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="LoanApprovalLoan" runat="server"></asp:Label>
                </td>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="AcctSummaryButton" runat="server" Text="Go to Account Summary" Width="238px" PostBackUrl="~/AccountSummary.aspx" />
                </td>
                <td class="auto-style3">
                    <asp:Button ID="AcctDetailsButton" runat="server" Text="Go to Account Details" Width="219px" PostBackUrl="~/AccountPages/AccountDetails.aspx" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
