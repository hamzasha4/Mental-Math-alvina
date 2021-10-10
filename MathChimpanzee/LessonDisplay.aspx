<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="LessonDisplay.aspx.cs" Inherits="MathChimpanzee.LessonDisplay" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
              
              <asp:DataList ID="DataList1" runat="server" DataSourceID="LessonsObject" >
                  <ItemTemplate>
                      id:
                      <asp:Label ID="idLabel" runat="server" Text='<%# Eval("id") %>' />
                      <br />
                      video:
                      <iframe width="560" height="315" src='<%# Eval("video") %>' title="YouTube video player" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe>
                      <asp:Label ID="videoLabel" runat="server" Text='<%# Eval("video") %>' />
                      <br />
                      <br />
                  </ItemTemplate>
              </asp:DataList>
              <asp:ObjectDataSource ID="LessonsObject" runat="server" SelectMethod="getLesson" TypeName="BussinessLayer.LessonBL">
                  <SelectParameters>
                      <asp:QueryStringParameter DefaultValue="1" Name="id" QueryStringField="Lesson" Type="Int32" />
                  </SelectParameters>
              </asp:ObjectDataSource>
              
    <asp:Button ID="btnToQuiz" runat="server" Text="Take Quiz" OnClick="btnToQuiz_Click" />
</asp:Content>


