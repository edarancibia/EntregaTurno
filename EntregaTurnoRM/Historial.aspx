<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Historial.aspx.cs" Inherits="EntregaTurnoRM.Historial" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <form id="form1" runat="server">
            <div class="row">
                <br />
                Fecha:<br />
                <asp:TextBox ID="txtfecha" runat="server" type="date"></asp:TextBox>
                <asp:Button ID="bntok" runat="server" Text="Buscar" class="btn btn-info" OnClick="bntok_Click" />
            </div>
            <br />
            <div class="row">
                <asp:GridView ID="dghistorial" runat="server" clas="table table-hover"></asp:GridView>
            </div>
        </form>
    </div>
</asp:Content>
