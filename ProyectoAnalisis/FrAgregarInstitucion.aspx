<%@ Page Title="" Language="C#" MasterPageFile="~/Index.Master" AutoEventWireup="true" CodeBehind="FrAgregarInstitucion.aspx.cs" Inherits="ProyectoAnalisis.FrAgregarInstitucion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <h4>Agregar nueva institucion </h4>
    <hr />
    <br />
    <form runat="server">
        <div class="form-group" runat="server">
            <div class="form-label-group" runat="server">
                <input type="text" runat="server" id="newInstitucion" class="form small" required="required">
                <label for="newInstitucion">Nueva Institucion</label>
                <br />

                <br />
            </div>
            <div class="form-label-group" runat="server">
                <br />
                <input type="date" runat="server" id="anoFront" class="form small" required="required">
                <label for="anoFront">Año de ingreso a la institucion</label><br />
                <%--<asp:TextBox TextMode="Date" Text='<%# Convert.ToDateTime(Eval("dateTime")).ToString("yyyy/MM/dd") %>' ID="anoFront" runat="server"  />--%>
            </div>
        </div>
        <asp:Button CssClass="btn-group-sm" ID="agregarInstitucion" Text="Agregar Institucion" runat="server" OnClick="agregarInstitucion_Click" />
        <div style="margin-left: auto; margin-right: auto; text-align: center;">
            <asp:Label runat="server" ID="label1" CssClass="text-danger text-center" Visible="false">Ya existe esta institucion</asp:Label>
        </div>

    </form>
</asp:Content>
