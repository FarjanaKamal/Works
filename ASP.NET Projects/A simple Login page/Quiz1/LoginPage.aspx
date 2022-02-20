<%@ Page Title="" Language="C#" MasterPageFile="~/Master/FrontEnd.Master" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="Quiz1.LoginPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Style/LoginAndSignUp.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <section id="heading" >
        <h1>Login </h1>
        </section>
        <section>
            <div id="loginInfo">
                          <asp:LoginView ID="LoginView2" runat="server">

<AnonymousTemplate>
<div id="login1">
<asp:Login ID="Login1" runat="server" CreateUserUrl="signup.aspx"

DestinationPageUrl="~/Default.aspx"

CreateUserText="Sign Up for a New Account " >

</asp:Login>
</div>


</AnonymousTemplate>

<LoggedInTemplate>

You are already logged in.

</LoggedInTemplate>

</asp:LoginView>
        
        </div>
        </section>
</asp:Content>
