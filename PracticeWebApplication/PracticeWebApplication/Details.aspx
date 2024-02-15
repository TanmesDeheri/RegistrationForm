<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Details.aspx.cs" Inherits="PracticeWebApplication.Details" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>


            <asp:DataList ID="DataList2" runat="server"
                OnItemCommand="DataList2_ItemCommand" RepeatColumns="5" Width="927px">
                <ItemTemplate>
                    <asp:Panel ID="Panel1" runat="server">
                        <table height="150">
                            <tr>
                                <td width="75%" align="center" style="color: #FF0000; font-weight: bold">
                                    <asp:ImageButton ID="Image1" runat="server" Width="100px" Height="70px" ImageUrl='<%#Eval("Productimage")%>' CommandName="ViewDetails" CommandArgument='<%#Eval("Productid") %>' />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <span style="color: Black; font-weight: bold;">Product Name</span>
                                    <asp:Label ID="lb1" runat="server" Text='<%#Eval("ProductName") %>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <span style="color: Black; font-weight: bold;">Product Details</span><br />
                                    <asp:Label ID="lbl2" runat="server" Text='<%#Eval("ProductDescription") %>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <span style="color: Black; font-weight: bold">Product Cost</span>
                                    <asp:Label ID="lbl3" runat="server" Text='<%#Eval("ProductCost") %>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <%--<asp:LinkButton ID="LinkButton1" runat="server" Font-Underline="False"style="font-weight:700; color:Black" CommandName="ViewDetails" CommandArgument='<%#Eval(Productid) %>'  BackColor="#FF9933">ViewDeatils</asp:LinkButton>--%>
                                    <asp:LinkButton ID="LinkButton2" runat="server" CommandName="ViewDetails" CommandArgument='<%#Eval("Productid") %>' OnClick="LinkButton_Click">ViewDeatils</asp:LinkButton>
                                </td>
                            </tr>
                        </table>
                    </asp:Panel>
                </ItemTemplate>
            </asp:DataList>

        </div>
    </form>
</body>
</html>
