<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserProfilePage.aspx.cs" Inherits="Quiz1.UserProfilePage" %>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>User Profile</title>
    <style>
        body {text-align:center;}
        #form1 {
            height: 515px;
            width: 650px;
            margin-left:400px;
             margin-top:60px;
        }
        #heading{
            background-color:cornflowerblue;
        }
        #LogoutBtn{
            float:right;
            font-weight: 700;
        }
        h1{
            text-align:center;
        }
        #Photo{
            float:left;
            height: 188px;
            width: 283px;
            padding:5px;
        }
        #ProfileInfo{
            float:right;
        }
        #ChangePhotoBtn{
            margin-top:5px;
            margin-left:3px;
        }
       
        .auto-style1 {}
       
        .auto-style2 {
            text-align: left;
            padding:5px
        }
       
    </style>
</head>
<body>
    <form id="form1" runat="server">       
        <section id="heading">
              <asp:Button ID="LogoutBtn" runat="server" Text="Log Out" OnClick="LogoutBtn_Click" BackColor="#CCCCFF" />
            <h1>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Admin Profile</h1>        
        </section>
       <section>
           <div id="Photo">
               &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
               <asp:Image ID="ProfilePhoto" runat="server" CssClass="auto-style1" Height="180px" ImageUrl="https://www.shareicon.net/data/512x512/2016/09/15/829452_user_512x512.png" Width="237px" />
            <asp:Button ID="ChangePhotoBtn" runat="server" Text="Change Photo" OnClick="ChangePhotoBtn_Click" />         
           </div>
           <div id="ProfileInfo">
               <asp:Panel ID="Panel1" runat="server" BorderStyle="Solid" CssClass="auto-style2" Width="295px" Height="255px">
                   <div class="auto-style2">
                       <br />
                       <strong>Name:</strong> Farjana Bintay Kamal<br /> <strong>Student Number: </strong>100206108<strong><br /> Course: </strong>CP380<br /> <strong>Section:</strong> T01<br /> <strong>Semester: </strong>Third<br /> <strong>Program:</strong> ICT Solutions for Business<br /> <strong>Hobby:</strong> Singing, and painting<br /> <strong>Pets: </strong>Cat<br /> <strong>Religion:</strong> Islam</div>
               </asp:Panel>
           </div>
           
        <p>
            &nbsp;</p>   
        </section>     
    </form>
</body>
</html>
