<%@ Page Title="" Language="C#" MasterPageFile="~/Index.Master" AutoEventWireup="true" CodeBehind="FrAgregarLicenciaConducir.aspx.cs" Inherits="ProyectoAnalisis.FrAgregarLicenciaConducir" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
       <h4>Agregar Licencia de Conducir.</h4>
    <hr />
    <br />
        <form runat="server">
        <div class="form-group" runat="server">
            <div class="form-label-group" runat="server">
                <input type="text" runat="server" id="txtLicencia" class="form small" required="required">
                <label for="newGradoEstudio">Nueva Licencia</label>
            </div>
        </div>
        <asp:Button CssClass="btn-group-sm btn-success" ID="agregarLicencia" Text="Agregar Licencia" runat="server" OnClick="agregarLicencia_Click" />
        <div style="margin-left: auto; margin-right: auto; text-align: center;">
            <asp:Label runat="server" ID="label1" CssClass="text-danger text-center " Visible="false">Ya existe este Licencia</asp:Label>
        </div>
            </form>
</asp:Content>
