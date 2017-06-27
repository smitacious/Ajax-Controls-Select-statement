<%@ Page Language="C#" MasterPageFile="~/Site.Master"AutoEventWireup="true" CodeBehind="DBManageCategorySelect.aspx.cs" Inherits="PetShop.DBManageCategorySelect" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <section class="main">
    <section class="content">
    <!-- insert main content here -->
      <h2>These are the current Product Categories</h2>
        <asp:BulletedList ID="CategoryLists" runat="server"></asp:BulletedList>
        <asp:Label ID="lblResults" runat="server" Text="Label"></asp:Label>
      <br /><br />
      <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/DBManageCategoryInsert.aspx">Click here to <strong>Insert a new Category</strong></asp:HyperLink>
      <br />
      <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/DBManageCategoryUpdate.aspx">Click here to <strong>Update a Category</strong></asp:HyperLink>
      <br />
      <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/DBManageCategoryDelete.aspx">Click here to <strong>Delete a Category</strong></asp:HyperLink>
      <br /><br />
    </ section>
  </ section>
</asp:Content>