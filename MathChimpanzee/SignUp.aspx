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
                           <asp:TextBox CssClass="form-control" ID="TextBox4" runat="server" placeholder="Name"></asp:TextBox>
                        </div>
                        <label>Email</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="test@gmail.com"></asp:TextBox>
                        </div>
                        <label>Password</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" 
                               placeholder="Password" TextMode="Password"></asp:TextBox>
                        </div>
                         <label>Confirm Password</label>
                         <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox3" runat="server" 
                               placeholder="Retype Password" TextMode="Password"></asp:TextBox><br>
                        </div>
                        <div class="form-group">
                           <asp:Button class="btn btn-info btn-block" ID="Button8" runat="server" Text="Sign Up" OnClick="Button8_Click" />
                        </div>
                     </div>
                  </div>
               </div>
                <a href="homepage.aspx"><< Back to Home</a><br><br>
            </div>
             </div>
          <div class="col-lg-1 col-12"></div>
            </div>
         </div>
      </div>

</asp:Content>
