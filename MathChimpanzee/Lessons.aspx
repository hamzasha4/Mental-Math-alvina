<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Lessons.aspx.cs" Inherits="MathChimpanzee.Lessons" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
                            <div>
                        <div class="form-group">
                           <asp:Button class="btn btn-info btn-block" ID="Button8" runat="server" Text="Lesson1" OnClick="Button9_Click" />
                        </div>
                     </div>
                            <div>
                        <div class="form-group">
                           <asp:Button class="btn btn-info btn-block" ID="Button1" runat="server" Text="Lesson2" OnClick="Button8_Click" />
                        </div>
                     </div>
        <div class="alert alert-danger alert-dismissible fade show">
        <strong>Locekd!</strong> Finish the previous lesson to unlock it.
        <button type="button" class="btn-close" data-bs-dismiss="alert"></button>
    </div>

</asp:Content>
