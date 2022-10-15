<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EjemploConMaster.aspx.cs" Inherits="First_Web_App.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Grito</h1>

    <div>
        <asp:TextBox ID="txtNombre"  runat="server"></asp:TextBox>
    </div>
    <div>
          <asp:Button ID="btnAceptar" OnClick="btnAceptar_Click"  runat="server" Text="Aceptar" />
    </div>
    <div>
        <asp:Label ID="lblSaludo" runat="server"></asp:Label>

    </div>
  

</asp:Content>
