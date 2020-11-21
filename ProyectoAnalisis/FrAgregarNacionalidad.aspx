<%@ Page Title="" Language="C#" MasterPageFile="~/Index.Master" AutoEventWireup="true" CodeBehind="FrAgregarNacionalidad.aspx.cs" Inherits="ProyectoAnalisis.FrAgregarNacionalidad" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <h4>Agregar Nacionalidad Nueva</h4>
    <hr />
    <br />
    <form runat="server">
        <div class="form-group" runat="server">
            <div class="form-label-group" runat="server">
                <input type="text" runat="server" id="newNacionalidad" class="form small" required="required">
                <label for="newNacionalidad">Nacionalidad Nueva</label>
            </div>
        </div>
        <asp:Button CssClass="btn-group-sm" ID="agregarIdioma" Text="Agregar Nacionalidad" runat="server" OnClick="agregarIdioma_Click" />
        <div style="margin-left: auto; margin-right: auto; text-align: center;">
            <asp:Label runat="server" ID="label1" CssClass="text-danger text-center" Visible="false">Ya existe esa Nacionalidad</asp:Label>
        </div>

    </form>


</asp:Content>
