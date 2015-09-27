<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SizePlay._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Welcome to SizePlay</h1>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Getting started</h2>
            <p>
                Enter your character's names and click begin.
            </p>
            <p>
                <a class="btn btn-default" href="SizePlay.aspx">Start Game &raquo;</a>
            </p>
        </div>
    </div>

</asp:Content>
