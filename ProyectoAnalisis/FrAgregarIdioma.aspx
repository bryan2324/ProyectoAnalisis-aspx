<%@ Page Title="" Language="C#" MasterPageFile="~/Index.Master" AutoEventWireup="true" CodeBehind="FrAgregarIdioma.aspx.cs" Inherits="ProyectoAnalisis.FrAgregarIdioma" %>

<script runat="server">
    protected void Page_PreInit(Object sender, EventArgs e)
    {
        this.MasterPageFile = "Index.Master";
        if (Session["admin"] != null)
        {
            this.MasterPageFile = "IndexAdmin.Master";
        }

        //solo para probar: este script para cambiar masterpagefile ya que esta pagina la comparte el usuario y el admin, este metodo 
        //se debe cambiar para validarlo de acuerdo al usuario//para cambiar masterpagefile ya que esta pagina la comparte el usuario y el admin
        //this.MasterPageFile = "Index.Master";
        //if(Request.Params["parametro"] != null)
        //{
        //    this.MasterPageFile = "IndexAdmin.Master";
        //}
    }
</script>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
     <h4>Agregar idioma.</h4>
    <hr />
    <br />
        <form runat="server">
        <div class="form-group" runat="server">
            <div class="form-label-group" runat="server">
                <input type="text" runat="server" id="txtIdioma" class="form small" required="required">
                <label for="newGradoEstudio">Nuevo Idioma</label>
            </div>
        </div>
        <asp:Button CssClass="btn-group-sm btn-success" ID="agregarIdioma" Text="Agregar Idioma" runat="server" OnClick="agregarIdioma_Click"  />
        <div style="margin-left: auto; margin-right: auto; text-align: center;">
            <asp:Label runat="server" ID="label1" CssClass="text-danger text-center" Visible="false">Ya existe este Idioma</asp:Label>
        </div>
            </form>
</asp:Content>
