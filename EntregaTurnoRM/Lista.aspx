<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Lista.aspx.cs" Inherits="EntregaTurnoRM.Lista" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        body
        {
            font-size: 12px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <form runat="server" id="form1">
            <asp:GridView ID="GridView1" runat="server" class="table-hover table table-responsive" HeaderStyle-HorizontalAlign="Center" OnSelectedIndexChanged="Page_Load" DataKeyNames="RUT" 
                OnRowCommand="GridView1_RowCommand">

                <Columns>

                    <asp:TemplateField HeaderText="" ItemStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center" >
                        <ItemTemplate>
                            <asp:Label ID="LblRut" runat="server" Text='<%# Eval("RUT") %>' Visible="False" ></asp:Label>

                        </ItemTemplate>

                        <HeaderStyle HorizontalAlign="Center"></HeaderStyle>

                        <ItemStyle HorizontalAlign="Center"></ItemStyle>
                </asp:TemplateField>

                <asp:TemplateField HeaderText=" " ItemStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center" >
                    <ItemTemplate>
                        <asp:ImageButton runat="server" ID="btnobs"  ImageUrl="~/imagenes/editar.ico" 
                              onClick="ClickLupa"
                             CommandName="image" ToolTip="Escribir comentarios" />
                    </ItemTemplate>
                    <HeaderStyle HorizontalAlign="Center"></HeaderStyle>

                    <ItemStyle HorizontalAlign="Center"></ItemStyle>
                  </asp:TemplateField>
                </Columns>


            </asp:GridView>
        </form>
    </div>
</asp:Content>
