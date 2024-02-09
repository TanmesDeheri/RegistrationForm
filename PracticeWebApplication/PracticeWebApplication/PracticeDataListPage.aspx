<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PracticeDataListPage.aspx.cs" Inherits="PracticeWebApplication.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
        <webopt:bundlereference runat="server" path="~/Content/css" />

    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="d-flex flex-sm-column flex-xs-column flex-lg-row m-3">
            <div class="d-flex flex-column w-50">
                <div>
                    <p>The DataList shows data of DataTable</p>
                </div>
                <asp:DataList ID="DataList1" runat="server">
                    <ItemTemplate>
                        <table cellpadding="2" cellspacing="0" border="1" style="width: 300px; height: 100px; border: dashed 2px #04AFEF; background-color: #FFFFFF">
                            <tr>
                                <th><b><span>Details:</span></b></th>
                            </tr>
                            <tr>
                                <td>
                                    <b>ID: </b><span class="city"><%# Eval("ID") %></span><br />
                                    <b>Name: </b><span class="postal"><%# Eval("Name") %></span><br />
                                    <b>Email: </b><span class="country"><%# Eval("Email")%></span><br />
                                </td>
                            </tr>
                        </table>
                    </ItemTemplate>
                </asp:DataList>
            </div>
            <div class="d-flex">
                <div>
                    <p>This DataGrid contains DataTable records </p>
                    <asp:DataGrid ID="DataGrid1" runat="server">
                    </asp:DataGrid>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
