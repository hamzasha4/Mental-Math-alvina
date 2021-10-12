<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="MathChimpanzee.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <div class="container text-center">
    <asp:Button class="btn btn-outline-success btn-block" ID="Login" runat="server" Text="Login" OnClick="Login_Click" />
    <br />
    <asp:Button class="btn btn-outline-info btn-block" ID ="Signup" runat="server" Text="Signup" OnClick="Signup_Click" />
    </div>
    <br />
</asp:Content>

