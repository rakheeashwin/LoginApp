<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="Login_App._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Welcome  <%: Context.User.Identity.GetUserName()  %> ! </h1>
    </div>
    <h2>Dashboard!! </h2>
   

</asp:Content>
