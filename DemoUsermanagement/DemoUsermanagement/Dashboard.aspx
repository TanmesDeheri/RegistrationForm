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
                            <a class="nav-link" href="#" id="dataTableLink">DataTable</a>
                        </li>
                        <li class=" nav-item">
                            <a class="nav-link" href="#" id="secondLink">Link2</a>
                        </li>
                        <li class=" nav-item">
                            <a class="nav-link" href="#" id="thirdLink" >Link 3</a>
                        </li>
                    </ul>
                    <a class=" navbar-brand">
                        <asp:Label ID="labelWelcomeMessage" runat="server" Font-Bold="true" ForeColor="WhiteSmoke"></asp:Label>
                    </a>
                </div>

            </nav>
        </div>
        <div class=" container-fluid mt-4" id="TableDataId">
            <uc:TableDataFromDB runat="server" ID="TableDataRecord" />
        </div>
    </form>
    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
<script>
    $(document).ready(function () {
        $("#TableData").hide();
        $("#dataTableLink").click(function (e) {
            e.preventDefault();
            $("#TableDataId").show();
        });
        $("#secondLink").click(function (e) {
            e.preventDefault();
            $("#TableDataId").hide();
        });
        $("#thirdLink").click(function (e) {
            e.preventDefault();
            $("#TableDataId").hide();
        });
    });
</script>

</body>
</html>
<!--https://localhost:44306/Dashboard?userEmail=deheritanmessom%40gmail.com-->
