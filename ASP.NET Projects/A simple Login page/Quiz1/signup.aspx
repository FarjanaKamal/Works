<%@ Page Title="" Language="C#" MasterPageFile="~/Master/FrontEnd.Master" AutoEventWireup="true" CodeBehind="signup.aspx.cs" Inherits="Quiz1.signup" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Style/LoginAndSignUp.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div>
                <section id="heading" >
                    <h1>Sign Up </h1>
                </section>
            <section>
                <div id="signIn">
                    <asp:CreateUserWizard ID="CreateUserWizard1" runat="server" ContinueDestinationPageUrl="~/LoginPage.aspx">
                <MailDefinition BodyFileName="~/App_Data/SignUpConfirmation.txt" Subject="Your New Account at CP380 Website">
                </MailDefinition>
                <WizardSteps>
                    <asp:CreateUserWizardStep runat="server" >
                    </asp:CreateUserWizardStep>
                    <asp:CompleteWizardStep runat="server" />
                </WizardSteps>
            </asp:CreateUserWizard>
                </div>
            </section>
             

        </div>
</asp:Content>
