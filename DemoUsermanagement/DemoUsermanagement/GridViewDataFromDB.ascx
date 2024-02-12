<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="GridViewDataFromDB.ascx.cs" Inherits="DemoUsermanagement.GridViewDataFromDB" %>
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
<asp:GridView ID="GridViewData" runat="server" AutoGenerateColumns="true" AllowPaging="true" PageSize="20" OnPageIndexChanging="GridViewPageIndexChanging" AllowSorting="true" CssClass="dark-theme-gridview">
    <PagerSettings Mode="NumericFirstLast" Position="Bottom" />
    <HeaderStyle CssClass="dark-theme-header" />
    <RowStyle CssClass="dark-theme-row" />
    <AlternatingRowStyle CssClass="dark-theme-alternating-row" />
    <PagerStyle CssClass="dark-theme-pager" />
</asp:GridView>
