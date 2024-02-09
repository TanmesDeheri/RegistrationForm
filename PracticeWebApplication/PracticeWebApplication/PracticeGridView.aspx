<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PracticeGridView.aspx.cs" Inherits="PracticeWebApplication.PracticeGridView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>GRID VIEW AND LIST VIEW</title>
    <webopt:BundleReference runat="server" Path="~/Content/css" />
    <style>
        .dark-theme-gridview {
            border-collapse: collapse;
            width: 100%;
            background-color: #333;
            color: #fff;
        }

        .dark-theme-header {
            background-color: #555;
            color: #fff;
            font-weight: bold;
            text-align: left;
            border: 1px solid #444;
        }

        .dark-theme-row {
            background-color: #444;
            border: 1px solid #333;
        }

        .dark-theme-alternating-row {
            background-color: #333;
            border: 1px solid #444;
        }

        .dark-theme-pager {
            background-color: #555;
            color: #fff;
            text-align: center;
        }
    </style>

</head>
<body>
    <form id="form1" runat="server">
        <div class=" container-fluid">
            <div class="container">
                <div class="container">
                    <asp:Label ID="GridViewLabel" runat="server"
                        Text="The Below Table Is The Grid View Of The The Data From Database" Font-Italic="True" Font-Size="X-Large"></asp:Label>
                </div>
            </div>

            <div>
                <asp:GridView ID="GridView1" AllowPaging="true" PageSize="20" OnPageIndexChanging="GridView1_PageIndexChanging" runat="server" CssClass="dark-theme-gridview">
                    <PagerSettings Mode="NumericFirstLast" Position="Bottom" />
                    <HeaderStyle CssClass="dark-theme-header" />
                    <RowStyle CssClass="dark-theme-row" />
                    <AlternatingRowStyle CssClass="dark-theme-alternating-row" />
                    <PagerStyle CssClass="dark-theme-pager" />
                </asp:GridView>
            </div>
            <div class="container">
                <h2>
                    <asp:Label runat="server" ID="ErrorMessage"></asp:Label></h2>
            </div>
        </div>
    </form>
</body>
</html>
