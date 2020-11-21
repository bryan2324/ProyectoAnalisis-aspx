<%@ Page Title="Nuevo Genero" Language="C#" MasterPageFile="~/Index.Master" AutoEventWireup="true" CodeBehind="FrAgregarGenero.aspx.cs" Inherits="ProyectoAnalisis.FrAgregarGenero" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <h4>Agregar Nuevo Genero</h4>
    <hr />
    <br />
    <form runat="server">
        <div class="form-group" runat="server">
            <div class="form-label-group" runat="server">
                <input type="text" runat="server" id="newGenero" class="form small" required="required">
                <label for="newNacionalidad">Genero Nuevo</label>
            </div>
        </div>
        <asp:Button CssClass="btn-group-sm" ID="agregarGenero" Text="Agregar Genero" runat="server" OnClick="agregarGenero_Click" />
        <div style="margin-left: auto; margin-right: auto; text-align: center;">
            <asp:Label runat="server" ID="label1" CssClass="text-danger text-center" Visible="false">Ya existe ese Genero</asp:Label>
        </div>

    </form>
</asp:Content>
