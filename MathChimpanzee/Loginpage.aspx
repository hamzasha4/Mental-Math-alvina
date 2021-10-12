<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Loginpage.aspx.cs" Inherits="MathChimpanzee.Login_page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="background-image: url('Images/wave.png');">
      <div class="row">
         <div class="col-md-5 mx-auto">
            <div class="card-transparent">
               <div class="card-body" style>
                  <div class="row">
                     <div class="col">
                        <center>
                           <img width="50px" src="Images/profile.png" />
                        </center>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <center>
                           <h3>Member Login</h3>
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
                        <label>Email</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="txtemail" runat="server" placeholder="Test@gmail.com" Width="400px"></asp:TextBox>
                        </div>
                        <label>Password</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="txtpassword" runat="server" 
                               placeholder="Password" TextMode="Password" Width="400px"></asp:TextBox>
                        </div>
                        <div class="form-group">
                           <asp:Button class="btn btn-outline-success btn-block" ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
                        </div>
                        <div class="form-group">
               <asp:Button class="btn btn-outline-info btn-block" ID="btnToSignUp" runat="server" Text="SignUp" OnClick="btnToSignUp_Click" />

                        </div>
                     </div>
                  </div>
               </div>
                <a href="homepage.aspx"><< Back to Home</a><br><br>
            </div>
             </div>
            
         </div>
      </div>
</asp:Content>
