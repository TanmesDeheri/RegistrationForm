<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="DemoUsermanagement.Dashboard" %>

<%@ Register Src="~/GridViewDataFromDB.ascx" TagName="TableDataFromDB" TagPrefix="uc" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Dashboard</title>
    <webopt:BundleReference runat="server" Path="~/Content/css" />
    <link href="~/favicon.ico" rel="shortcut icon" type="image/x-icon" />
    <style>
        .nav-link, .nav-link:visited {
            cursor: pointer;
            color: whitesmoke;
        }

        .nav-link:hover {
                color: forestgreen;
            }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <nav class=" navbar navbar-expand-sm bg-dark ">

                <div class=" container-fluid ">
                    <!-- Links -->
                    <ul class=" navbar-nav">
                        <li class=" nav-item">
                            <a class="nav-link" href="#">DataTable</a>
                        </li>
                        <li class=" nav-item">
                            <a class="nav-link" href="#">Link2</a>
                        </li>
                        <li class=" nav-item">
                            <a class="nav-link" href="#">Link 3</a>
                        </li>
                    </ul>
                    <a class=" navbar-brand">
                        <asp:Label ID="labelWelcomeMessage" runat="server" Font-Bold="true" ForeColor="WhiteSmoke"></asp:Label>
                    </a>
                </div>

            </nav>
        </div>
        <div class=" container-fluid mt-4">
            <uc:TableDataFromDB runat="server" ID="TableDataRecord" />
        </div>
    </form>
</body>
</html>
<!--https://localhost:44306/Dashboard?userEmail=deheritanmessom%40gmail.com-->
