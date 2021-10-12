<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Score.aspx.cs" Inherits="MathChimpanzee.Score" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Score</h1>
    <asp:Label ID="score" runat="server" Text=""></asp:Label>
    <br />
    <br />
    <br />
    <br />
    <asp:Button ID="BtnToLesson" runat="server" Text="Lesson" OnClick="BtnToLesson_Click" />
</asp:Content>
