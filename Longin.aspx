<%@ Page Title="" Language="C#" MasterPageFile="~/Home003.Master" AutoEventWireup="true" CodeBehind="Longin.aspx.cs" Inherits="HomeWork003.Longin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    帳號:<asp:TextBox runat="server"></asp:TextBox>
    密碼:<asp:TextBox runat="server"></asp:TextBox>
    <asp:Literal ID="Literal1" runat="server"></asp:Literal>
    <asp:Button runat="server" Text="Longin" />
</asp:Content>

