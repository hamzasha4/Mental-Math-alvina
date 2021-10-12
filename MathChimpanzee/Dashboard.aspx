<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="MathChimpanzee.Dashboard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" class="dd">
    <div id="main">
    <div class="db rounded-3">
        <div class="side-bar">
          <ul>
              <li>&nbsp;&nbsp;</li>
              <li></li>
              <li>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                  <img src="Images/dsahboard.png" style="width:30px;"/></li>
              <li> &nbsp; Dashboard </li>
          </ul>
            <p>
                &nbsp;</p>
            <ul>
                <li> </li>
                <li>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                    <img src="Images/profile.png" style="width:30px;"/> </li>
                <li>&nbsp; Profile </li>
          </ul>
            <p>
                &nbsp;</p>
            <ul>
                <li>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                    <img src="Images/Lesson.png" style="width:30px;"/> </li>
                <li>&nbsp; Lessons </li>
                <li></li>
                <li>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                    <img src="Images/Progress.png" style="width:30px;"/> </li>
                <li>&nbsp; Progress </li>
          </ul>
        </div>
        <div class="content">
            <asp:Button ID="BtnToLesson" runat="server" Text="Lesson" OnClick="BtnToLesson_Click" />

            <div class="bg-image hover-overlay">
  <img src="Images/icons8-online-education-50.png"/>
  <div
    class="mask"
    style="
      background: linear-gradient(
        45deg,
        rgba(29, 236, 197, 0.5),
        rgba(91, 14, 214, 0.5) 100%
      );
    "
  ></div>
</div>
            </div>
        </div>
    </div>
</asp:Content>
