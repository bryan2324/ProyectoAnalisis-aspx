<%@ Page Title="" Language="C#" MasterPageFile="~/IndexAdmin.Master" AutoEventWireup="true" CodeBehind="FrAgregarInfoRequisitos.aspx.cs" Inherits="ProyectoAnalisis.FrInfoRequisitos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
            <h3 class="text-info">Informacion sobre requisitos</h3>
    <hr />
    <form runat="server">
        <div class="form-group" runat="server">
        <hr />
            <label>Idioma Requerido</label>
            <br />
            <asp:DropDownList ID="ListaIdiomas" Height="35px" Width="150px" CssClass="btn-outline-dark  " runat="server" EnableViewState="true" Enabled="true" AppendDataBoundItems="true" />
            <asp:Button ID="addIdioma" runat="server" Text="Agregar otro Idioma" CssClass="btn-outline-secondary" OnClick="addIdioma_Click" />
            <br />
            <label>Carrera</label>
            <br />
            <asp:DropDownList ID="listaCarreras" Height="35px" runat="server" CssClass="btn-outline-dark" Width="150px" EnableViewState="true" Enabled="true" AppendDataBoundItems="true" />
            <asp:Button ID="addCarrera" runat="server" CssClass="btn-outline-secondary" Text="Agregar mas Carreras" Width="240px" OnClick="addCarrera_Click" />
            <br />
            <label>Grado de Estudio</label>
            <br />
            <asp:DropDownList ID="listaGrado" Height="35px" runat="server" CssClass="btn-outline-dark" Width="150px" EnableViewState="true" Enabled="true" AppendDataBoundItems="true" />
            <asp:Button ID="addGrado" runat="server" Text="Agregar mas Grados de estudio" CssClass="btn-outline-secondary" Width="240px" OnClick="addGrado_Click" />
            <%--         <br />
        <div class="form-label-group form-group">
            <input type="text" id="txtHabilidades" runat="server" class="input-group-lg" autofocus="autofocus">
            <label for="txtHabilidades">Habilidad de la persona para el puesto</label>
        </div>--%>
            <br /><br />
            <label>Habilidad requeridad</label>
            <br />

    
            <br />
            <asp:DropDownList ID="listaHabilidad" Height="35px" runat="server" CssClass="btn-outline-dark" Width="150px" EnableViewState="true" Enabled="true" AppendDataBoundItems="true" />
            <%--<asp:Button ID="Button1" runat="server" Text="Agregar mas Grados de estudio" CssClass="btn-outline-secondary" Width="240px" OnClick="addGrado_Click" />--%>
            <br />
        </div>
        <br />


        <asp:Button CssClass="btn-group-sm" ID="agregarRequisito" Text="Agregar requisitos" runat="server" OnClick="agregarRequisito_Click" />
        <div style="margin-left: auto; margin-right: auto; text-align: center;">
            <asp:Label runat="server" ID="labelRequisito" CssClass="text-danger text-center" Visible="false">Ya existe estos requisitos</asp:Label>
        </div>

    </form>

</asp:Content>
