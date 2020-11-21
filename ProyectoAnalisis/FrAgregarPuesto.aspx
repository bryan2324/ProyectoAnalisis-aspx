<%@ Page Title="" Language="C#" MasterPageFile="~/IndexAdmin.Master" AutoEventWireup="true" CodeBehind="FrAgregarPuesto.aspx.cs" Inherits="ProyectoAnalisis.FrAgregarPuesto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <h4>Agregar nueva puesto de trabajo</h4>
    <hr />
    <br />
    <form runat="server">
        <div class="form-group" runat="server">
            <div class="form-label-group" runat="server">
                <input type="text" runat="server" id="newPuesto" class="form small" required="required">
                <label for="newCarrera">Puesto Nuevo</label>
            </div>
        </div>
        <asp:Button CssClass="btn-group-sm" ID="agregarPuesto" Text="Agregar Puesto" runat="server" OnClick="agregarPuesto_Click" />
        <div style="margin-left: auto; margin-right: auto; text-align: center;">
            <asp:Label runat="server" ID="label1" CssClass="text-danger text-center" Visible="false">Ya existe este puesto</asp:Label>
        </div>

    </form>
</asp:Content>
