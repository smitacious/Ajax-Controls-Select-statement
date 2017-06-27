<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SearchPets.aspx.cs" Inherits="PetShop.SearchPets" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajax" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <section class="main">
    <section class="content">
      <!-- insert main content here -->
      <center>
      <asp:Label ID="Label1" runat="server" Text="Label"><strong>Start typing a name in the input field below: </strong></asp:Label>
      <br /><br />
   
      
      <asp:TextBox ID="TextBox1" runat="server" Height="20px" Width="200px"></asp:TextBox>
      <ajax:AutoCompleteExtender ID="TextBox1_AutoCompleteExtender" runat="server" 
        BehaviorID="TextBox1_AutoCompleteExtender" DelimiterCharacters=""
        MinimumPrefixLength="2"
        ServiceMethod="GetHint" 
        TargetControlID="TextBox1">
      </ajax:AutoCompleteExtender>
      
      <br />  <br />    
      <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Search" Width="100px" />      
      <br /><br />
      </center>
    </section>
  </section>  
</asp:Content>



