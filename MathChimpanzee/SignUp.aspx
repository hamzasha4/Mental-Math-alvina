<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="MathChimpanzee.Sign_Up" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="
background-image: url('Images/wave.png');">
<div class="container-fluid">
<div class="row">
<div class="col-lg-6 col-12">
<div class="row">
<div class="col-12"></div>
<div class="col-12">
</div>
</div>
</div>
<div class="col-lg-5 col-12 mx auto">
<div class="card" style="background-color:#00BFA6">
<div class="card-body">
<div class="row">
<div class="col">
<center>
<img width="100px" src="imgs/generaluser.png"/>
</center>
</div>
</div>
<div class="row">
<div class="col">
<center>
<h3>Sign Up</h3>
</center>
</div>
</div>
<div class="row">
<div class="col">
<hr>
</div>
</div>
<div class="row">
<div class="col">
<label>User Name</label>
<div class="form-group">
<asp:TextBox CssClass="form-control" ID="txtusername" runat="server" placeholder="Name" Width="357px"></asp:TextBox>
<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtusername" ErrorMessage="*User Name Required" ForeColor="Red"></asp:RequiredFieldValidator>
</div>
<label>Email</label>
<div class="form-group">
<asp:TextBox CssClass="form-control" ID="txtemail" runat="server" placeholder="test@gmail.com" Width="357px"></asp:TextBox>
<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtemail" ErrorMessage="*Email Required" ForeColor="Red"></asp:RequiredFieldValidator>
<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtemail" ErrorMessage="*Invalid Email Address" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ForeColor="Red"></asp:RegularExpressionValidator>
</div>
<label>Password</label>
<div class="form-group">
<asp:TextBox CssClass="form-control" ID="txtpassword" runat="server"
placeholder="Password" TextMode="Password" Width="357px"></asp:TextBox>
<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtpassword" ErrorMessage="*Password Required" ForeColor="Red" ></asp:RequiredFieldValidator>
<asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtpassword" ErrorMessage="*Enter more than 8 character password" ValidationExpression="^[\s\S]{8,}$" ForeColor="Red"></asp:RegularExpressionValidator>
</div>
<label>Confirm Password</label>
<div class="form-group">
<asp:TextBox CssClass="form-control" ID="txtconfirmpassword" runat="server" Width="357px" 
placeholder="Retype Password" TextMode="Password"></asp:TextBox>
<asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtpassword" ControlToValidate="txtconfirmpassword" ErrorMessage="*Password Dont Match" ForeColor="Red"></asp:CompareValidator>
<br>
</div>
<label>Age</label>
<div class="form-group">
<asp:TextBox CssClass="form-control" ID="txtage" runat="server" 
placeholder="Age" TextMode="Number" max="100" min="1" Width="357px"></asp:TextBox>
<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtage" ErrorMessage="*Age Required" ForeColor="Red"></asp:RequiredFieldValidator>
<asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtage" ErrorMessage="*Enter Correct Age" MaximumValue="100" MinimumValue="1" Type="Integer" ForeColor="Red"></asp:RangeValidator>
<br />
<br>
</div>
<div class="form-group">
<asp:Button class="btn btn-info btn-block" ID="btnSignUp" runat="server" Text="Sign Up" OnClick="btnSignUp_Click"/>
</div>
</div>
</div>
</div>
<a href="Home.aspx"><< Back to Home</a><br><br>
</div>
</div>
<div class="col-lg-1 col-12"></div>
</div>
</div>
</div></asp:Content>

