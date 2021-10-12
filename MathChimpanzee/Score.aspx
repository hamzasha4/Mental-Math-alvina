<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Score.aspx.cs" Inherits="MathChimpanzee.Score" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="text-center">
    <h1>Score</h1>
        <br />

    <asp:Label class="h5" ID="score" runat="server" Text=""></asp:Label>
    <br />
    <br />
    <br />
    <br />
    <asp:Button class="btn btn-outline-danger btn-lg" ID="BtnToLesson" runat="server" Text="Lesson" OnClick="BtnToLesson_Click" />
</div>
</asp:Content>
