<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FirstPage.aspx.cs" Inherits="PracticeWebApplication.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .container {
            margin: 0px;
        }

        div {
            margin: 10px 0px 0px 10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h2>HELLO!!,Welcome To This Site.😀</h2>
            <div class="FormHeading">
                <asp:Label ID="Label1" runat="server" Text="Enter The Following Details:" ForeColor="Black"></asp:Label>
            </div>
            <div class="UsernameBox">
                <asp:Label ID="labelId" runat="server">User Name</asp:Label>
                <asp:TextBox ID="UserName" runat="server" ToolTip="Enter User Name"></asp:TextBox>
            </div>
            <div class="GenderBox">
                <asp:RadioButton ID="RadioButton1" runat="server" Text="Male" GroupName="gender" />
                <asp:RadioButton ID="RadioButton2" runat="server" Text="Female" GroupName="gender" />
            </div>
            <div class="DateBox">
                <h2>Select Date from the Calender</h2>
                <div>
                    <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
                </div>
            </div>
            <div class="CourseBox">
                <h2>Select Courses</h2>
                <asp:CheckBox ID="CheckBox1" runat="server" Text="J2SE" />
                <asp:CheckBox ID="CheckBox2" runat="server" Text="J2EE" />
                <asp:CheckBox ID="CheckBox3" runat="server" Text="Spring" />
            </div>
            <p>
                <asp:Button ID="SubmitButton" runat="server" Text="Submit" OnClick="SubmitButtonClick" />
            </p>
        </div>

    </form>
    <asp:Label ID="userInput" runat="server"></asp:Label>
    <br />
    <asp:Label runat="server" ID="genderId"></asp:Label>
    <br />
    <asp:Label runat="server" ID="ShowDate"></asp:Label>
    <br />
    <p>
        Courses Selected:
        <asp:Label runat="server" ID="ShowCourses"></asp:Label>
    </p>
    <br />
    <asp:HyperLink ID="HyperLink1" runat="server" Text="JavaTpoint" NavigateUrl="https://www.javatpoint.com/asp-net-hyperlink"></asp:HyperLink>
</body>
</html>
