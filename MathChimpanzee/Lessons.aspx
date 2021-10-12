<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Lessons.aspx.cs" Inherits="MathChimpanzee.Lessons" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
                            <div>
                        <div class="form-group">
                           <asp:Button class="btn btn-info btn-block" ID="btnLesson1" runat="server" Text="Lesson1" OnClick="btnLesson1_Click" />
                        </div>
                     </div>
                            <div>
                        <div class="form-group">
                           <asp:Button class="btn btn-info btn-block" ID="Button1" runat="server" Text="Lesson2" OnClick="btnLesson2_Click" />
                        </div>
                     </div>
                            <br />
                            <br />
                            <br />
                            <br />

</asp:Content>
