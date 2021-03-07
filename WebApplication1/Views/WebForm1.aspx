<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.Views.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <label>
        <span>Name</span>
        <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox>
    </label>
    <br />
    <br />
    <label>
        <span>Count</span>
        <asp:TextBox ID="countTextBox" runat="server"></asp:TextBox>
    </label>
    <br />
    <br />
    <asp:Button OnClick="Add_Click" Text="Add product" runat="server" />
</asp:Content>
