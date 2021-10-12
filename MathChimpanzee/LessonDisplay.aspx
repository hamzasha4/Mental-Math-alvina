<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="LessonDisplay.aspx.cs" Inherits="MathChimpanzee.LessonDisplay" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
            <div class="text-center">  
              <asp:DataList ID="DataList1" runat="server" DataSourceID="LessonsObject" >
                  <ItemTemplate>
                      Lesson No :
                      <asp:Label ID="idLabel" runat="server" Text='<%# Eval("id") %>' />
                      <br />
                      <iframe width="560" height="315" src='<%# Eval("video") %>' title="YouTube video player" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe>
                      <br />
                      <br />
                  </ItemTemplate>
              </asp:DataList>
              <asp:ObjectDataSource ID="LessonsObject" runat="server" SelectMethod="getLesson" TypeName="BussinessLayer.LessonBL">
                  <SelectParameters>
                      <asp:QueryStringParameter DefaultValue="1" Name="id" QueryStringField="Lesson" Type="Int32" />
                  </SelectParameters>
              </asp:ObjectDataSource>
              
   <asp:Button CssClass="btn btn-outline-danger btn-lg" ID="btnToQuiz" runat="server" Text="Take Quiz" OnClick="btnToQuiz_Click" />

<asp:Button CssClass="btn btn-outline-info btn-lg" ID="btntoPractice" runat="server" OnClick="btntoPractice_Click" Text="Practice" />
</div>
</asp:Content>


