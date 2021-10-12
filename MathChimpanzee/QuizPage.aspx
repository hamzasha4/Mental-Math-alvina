<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="QuizPage.aspx.cs" Inherits="MathChimpanzee.QuizPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

  <script src="https://cdn.jsdelivr.net/npm/@mediapipe/camera_utils/camera_utils.js" crossorigin="anonymous"></script>
  <script src="https://cdn.jsdelivr.net/npm/@mediapipe/control_utils/control_utils.js" crossorigin="anonymous"></script>
  <script src="https://cdn.jsdelivr.net/npm/@mediapipe/drawing_utils/drawing_utils.js" crossorigin="anonymous"></script>
  <script src="https://cdn.jsdelivr.net/npm/@mediapipe/hands/hands.js" crossorigin="anonymous"></script>
        
        <style>
        .loader {
            position: absolute;
            left: 50%;
            top: 50%;
            z-index: 1;
            width: 120px;
            height: 120px;
            margin: -76px 0 0 -76px;
              border-top: 16px solid blue;
             border-right: 16px solid green;
             border-bottom: 16px solid red;
             border-left: 16px solid pink;
            border-radius: 50%;
            border-top: 16px solid #3498db;
            -webkit-animation: spin 2s linear infinite;
            animation: spin 2s linear infinite;
        }

@keyframes spin {
  0% { transform: rotate(0deg); }
  100% { transform: rotate(360deg); }
}
        .hidden {
            display: none;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <br />

<div class="container">
    <div class="loader" id="loaddiv"></div>
  <div class="row">
    <div class="col-sm-8">
    <video class="input_video" width="0">Loading</video>
    <canvas class="output_canvas" id="c"></canvas>
    </div>
    <div class="col-sm-4 text-center">
    <br />
    <span id="time"></span> <br />
    <asp:label ID="Questions" runat="server" ClientIDMode="Static"></asp:label>
    <br />
    <asp:HiddenField ID="hf" runat="server" ClientIDMode="Static" />
    <asp:HiddenField ID="result" runat="server"  ClientIDMode="Static" />


    <span id="text" style="font-size:20px;color:red"></span>

    <br />
    <span id="verifyans"></span> 
        <br />
        <br />
        <asp:Button class="btn btn-outline-danger btn-lg" ID="submit" runat="server" ClientIDMode="Static" OnClick="submit_Click" Text="Finish" />

    </div>
  </div>
</div> 
    <script src="Scripts/mp8.js"></script>
</asp:Content>
