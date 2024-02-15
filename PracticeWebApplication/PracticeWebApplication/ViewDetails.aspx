<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewDetails.aspx.cs" Inherits="PracticeWebApplication.ViewDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <table class="style3">
                <tr>
                    <td class="style6"></td>
                    <td class="style5">
                        <table class="style1">
                            <tr>
                                <td class="style2">
                                    <asp:Image ID="Image1" runat="server" Width="301px" Height="209px"
                                        Style="margin-right: 130px" />
                                </td>
                            </tr>
                            <tr>
                                <td style="color: #0000FF; font-weight: 700">
                                    <span style="color: Black; font-weight: bold;">Modal:</span><br />
                                    <asp:Literal ID="Literal1" runat="server"></asp:Literal>
                                </td>
                            </tr>

                            <tr>
                                <td style="font-weight: 700; color: #009933">
                                    <span style="color: Black; font-weight: bold;">ProductDetails:</span><br />
                                    <asp:Literal ID="Literal2" runat="server"></asp:Literal>
                                </td>
                            </tr>
                            <tr>
                                <td style="font-weight: 700; color: #FF0000">
                                    <span style="color: Black; font-weight: bold;">Price:</span><br />
                                    <asp:Literal ID="Literal3" runat="server"></asp:Literal>

                                </td>
                            </tr>
                        </table>
                        <td class="style4">

                        </td>
                </tr>
                <tr>
                    <td class="style6"></td>
                    <td class="style5">
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Details.aspx">Goto Home Page</asp:HyperLink>
                        <td class="style4"></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
