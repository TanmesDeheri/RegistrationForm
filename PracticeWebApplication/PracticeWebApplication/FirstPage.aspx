<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FirstPage.aspx.cs" Inherits="PracticeWebApplication.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <webopt:bundlereference runat="server" path="~/Content/css" />
     <asp:PlaceHolder runat="server">
     <%: Scripts.Render("~/bundles/modernizr") %>
 </asp:PlaceHolder>
    <style>
        .container {
            margin: 0px;
        }

        div {
            margin: 10px 0px 0px 10px;
        }

        .Result {
            background-color: burlywood;
            color: black;
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
            <div class="FileUploadBox">
                <p>Browse to Upload File</p>
                <asp:FileUpload ID="FileUpload1" runat="server" />
            </div>
            <div class="MultipleFileUploadBox">
                <h3>Upload Multiple Files</h3>
                <asp:FileUpload ID="FileUpload2" runat="server" AllowMultiple="true" />
            </div>
            <div class="ChoiceBox">
                <asp:Label ID="Label2" runat="server" Text="Select Brand Preferences"></asp:Label>
                <br />
                <br />
                <asp:CheckBox ID="apple" runat="server" Text="Apple" />
                <br />
                <asp:CheckBox ID="dell" runat="server" Text="Dell" />
                <br />
                <asp:CheckBox ID="lenevo" runat="server" Text="Lenevo" />
                <br />
                <asp:CheckBox ID="acer" runat="server" Text="Acer" />
                <br />
                <asp:CheckBox ID="sony" runat="server" Text="Sony" />
                <br />
                <asp:CheckBox ID="wipro" runat="server" Text="Wipro" />
                <br />
            </div>
            <div class="dropdown">
                <p>Select a City of Your Choice</p>
                <div>
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem Value="">Please Select</asp:ListItem>
                        <asp:ListItem>New Delhi </asp:ListItem>
                        <asp:ListItem>Greater Noida</asp:ListItem>
                        <asp:ListItem>NewYork</asp:ListItem>
                        <asp:ListItem>Paris</asp:ListItem>
                        <asp:ListItem>London</asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>
            <p>
                <asp:Button ID="SubmitButton" runat="server" Text="Submit" OnClick="SubmitButtonClick" CssClass="btn-outline-success" />
            </p>
        </div>
        <div class="Result" id="Result">
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
            <p>
                <asp:Label runat="server" ID="FileUploadStatus"></asp:Label>
            </p>
            <br />
            <p>
                <asp:Label runat="server" ID="MultipleFileUploadStatus"></asp:Label>
            </p>
            <asp:HyperLink ID="HyperLink1" runat="server" Text="JavaTpoint" NavigateUrl="https://www.javatpoint.com/asp-net-hyperlink"></asp:HyperLink>
            <div class="DownloadBox">
                <p>
                    Click the button to download a file
                </p>
                <asp:Button ID="Button1" runat="server" OnClick="DownloadOnClick" Text="Download" CssClass="btn-outline-success" />
                <br />
                <asp:Label ID="DownloadResult" runat="server"></asp:Label>
            </div>
            <br />
            <p>
                <asp:Label ID="Choices" runat="server"></asp:Label>
            </p>
            <asp:Label ID="LabelForDropdown" runat="server"></asp:Label>

        </div>
    </form>
</body>
</html>
