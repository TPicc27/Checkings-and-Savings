﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AccountDetails.aspx.cs" Inherits="Assignment_2.AccountPages.AccountDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 259px;
        }
        .auto-style3 {
            width: 234px;
        }
        .auto-style4 {
            width: 220px;
        }
        .auto-style5 {
            width: 237px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">Account Name:</td>
                <td class="auto-style3">
                    <asp:Label ID="AccountNameLabel" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Account Type:</td>
                <td class="auto-style3">
                    <asp:Label ID="AcctTypeLabel" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Account Balance:</td>
                <td class="auto-style3">
                    <asp:Label ID="BalanceLabel" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td class="auto-style4">
                    <asp:TextBox ID="WithdrawTB" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style5">
                    <asp:Button ID="WithdrawButton" runat="server" Text="Withdraw Money" Width="187px" OnClick="WithdrawButton_Click" />
                </td>
                <td>
                    <asp:Label ID="WithdrawErrorLabel" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Eligible for Loan:</td>
                <td class="auto-style3">
                    <asp:Label ID="LoanLabel" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style5">
                    <asp:Button ID="LoanButton" runat="server" Text="Want a Loan?" Width="186px" PostBackURL="~/AccountPages/LoadApplicationPage.aspx"/>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Address Provided:</td>
                <td class="auto-style3">
                    <asp:Label ID="AddressLabel" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
