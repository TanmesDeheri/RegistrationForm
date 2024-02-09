<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ValidationPractice.aspx.cs" Inherits="PracticeWebApplication.ValidationPractice" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }

        .auto-style2 {
            height: 26px;
        }

        .auto-style3 {
            height: 26px;
            width: 93px;
        }

        .auto-style4 {
            width: 93px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style3">First value</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="firstval" runat="server" required="true"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Second value</td>
                    <td>
                        <asp:TextBox ID="secondval" runat="server"></asp:TextBox>
                        It should be greater than first value</td>
                </tr>
                <tr>
                    <td class="auto-style4"></td>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="save" />
                    </td>
                </tr>
            </table>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="secondval"
                ControlToValidate="firstval" Display="Dynamic" ErrorMessage="Enter valid value" ForeColor="Red"
                Operator="LessThan" Type="Integer"></asp:CompareValidator>
        </div>
        <div class="auto-style1">
            <p class="auto-style4">
                Enter value between 100 and 200<br />
            </p>
            <table class="auto-style2">
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label2" runat="server" Text="Enter a value"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="uesrInput" runat="server"></asp:TextBox>
                        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="uesrInput"
                            ErrorMessage="Enter value in specified range" ForeColor="Red" MaximumValue="199" MinimumValue="101"
                            SetFocusOnError="True" Type=" Integer"></asp:RangeValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3"></td>
                    <td>
                        <br />
                        <asp:Button ID="Button2" runat="server" Text="Save" />
                    </td>
                </tr>
            </table>
            <br />
            <br />
        </div>
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">User Name</td>
                    <td>
                        <asp:TextBox ID="username" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="user" runat="server" ControlToValidate="username"
                            ErrorMessage="Please enter a user name" ForeColor="Red">
                        </asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Password</td>
                    <td>
                        <asp:TextBox ID="password" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="pass" runat="server" ControlToValidate="password" ErrorMessage="Please enter a password"
                            ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2"></td>
                    <td>
                        <br />
                        <asp:Button ID="Button3" runat="server" Text="login" />
                    </td>
                </tr>
            </table>
        </div>
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">User Name</td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1"
                            ErrorMessage="Please enter a user name" ForeColor="Red">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Password</td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2"
                            ErrorMessage="Please enter a password" ForeColor="Red">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <br />
                        <asp:Button ID="Button4" runat="server" Text="login" />
                    </td>
                    <td>
                        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
                        <br />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
