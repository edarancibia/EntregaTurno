<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="IngresoDatos.aspx.cs" Inherits="EntregaTurnoRM.IngresoDatos" %>
<%@ PreviousPageType VirtualPath="~/Lista.aspx"%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <form id="form1" runat="server">
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
            <asp:TextBox ID="txtrut" runat="server" Value='<%# Request.QueryString["RUT"]%>'></asp:TextBox>
        </form>
    </div>
</asp:Content>
