﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Master/FrontEnd.Master" AutoEventWireup="true" CodeBehind="Food.aspx.cs" Inherits="Project_CuisineDelight.Food" %>

<%@ Register Src="~/UserViewingtems.ascx" TagPrefix="uc1" TagName="UserViewingtems" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
             <asp:SiteMapPath ID="SiteMapPath1" runat="server"></asp:SiteMapPath>
    </div>
     <div class="container py-4 container-fluid">
                <div class="d-flex justify-content-between flex-wrap flex-md-nowrap align-items-center pt-3 pb-2 mb-3 border-bottom">
                    <h1 class="h2">Food Items</h1>
                </div>
                  <hr />
                   <uc1:UserViewingtems runat="server" id="UserViewingtems" />
    
            </div>
</asp:Content>