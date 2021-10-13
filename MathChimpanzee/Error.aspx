<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Error.aspx.cs" Inherits="MathChimpanzee.Error" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="text-center container">
    <asp:Label CssClass="h5" Text="An Unknown Error Occured Please Contact Your Administrator" runat="server" />
        <br />
        <br />
        <asp:Button CssClass="btn btn-outline-danger btn-lg" Text="Go To DashBoard" runat="server" ID="btnToDashboard" OnClick="btnToDashboard_Click" />
    </div>
</asp:Content>
