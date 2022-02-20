<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ErrorPage.aspx.cs" Inherits="Quiz1.ErrorPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        section{
            text-align:center;
        }
        #form1 {
            margin-left:500px
        }
        #error{
            background-color:red;
            height:50px;     
            font:100px; 
            padding:50px;
            margin-top:100px
            
        }
        .auto-style1 {
            height: 124px;
            width: 999px;
        }
        #TryLoginBtn{
            margin:20px;
            font-weight: 700;
        }
    </style>
</head>
<body class="auto-style1">
    <form id="form1" runat="server">
        <section id="error">
            <div>
                <h1>
                <strong>Invalid UserName or Password !!
        </strong>
                </h1>
        </div>
        </section>
        <section>
              <asp:Button ID="TryLoginBtn" runat="server" Text="Try Again" OnClick="TryLoginBtn_Click" BackColor="#FFCC99" Height="51px" Width="110px" />
        
        </section>
        
      
    </form>
</body>
</html>
