<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login Page.aspx.cs" Inherits="Quiz1.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        #form1 {
            height: 300px;
            width: 600px;
            text-align:center;
            margin-left:450px;
            margin-top:60px;
            border:solid
        }
        #heading{
            background-color: cadetblue
        }
         h1{
            text-align:center;
            padding:20px
        }
         #Login1{
             margin-left:100px
         }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <section id="heading">
            <h1>Login </h1>
        </section>
        <section>
            <div id="loginInfo">
            <asp:Login ID="Login1" runat="server" DestinationPageUrl="~/UserProfilePage.aspx" OnAuthenticate="Login1_Authenticate" Width="392px" TitleText="">
        </asp:Login>
        </div>
        </section>
        
        
    </form>
</body>
</html>
