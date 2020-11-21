<%@ Page Title="" Language="C#" MasterPageFile="~/Index.Master" AutoEventWireup="true" CodeBehind="FrMostrarConcursos.aspx.cs" Inherits="ProyectoAnalisis.FrMostrarConcursos" %>

<script runat="server">
    protected void Page_PreInit(Object sender, EventArgs e)
    {
        this.MasterPageFile = "Index.Master";
        if (Session["admin"] != null)
        {
            this.MasterPageFile = "IndexAdmin.Master";
        }
        //solo para probar: este script para cambiar masterpagefile ya que esta pagina la comparte el usuario y el admin, este metodo 
        //se debe cambiar para validarlo de acuerdo al usuario
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



    <form runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel2" runat="server">
            <ContentTemplate>

                <h4>Concursos</h4>
        <hr />
        <br />
        <div style="overflow: scroll">
            <asp:GridView ID="gvMostrarConcursos" runat="server" CssClass="table table-striped table-bordered dt-responsive nowrap" EnableTheming="True" AllowPaging="True" OnPageIndexChanging="gvMostrarConcursos_PageIndexChanging" PageSize="5" OnSelectedIndexChanged="gvMostrarConcursos_SelectedIndexChanged">
                <Columns>
                    <asp:ButtonField CommandName="Select" Text="Seleccionar" />
                </Columns>
            </asp:GridView>
        </div>

        <fieldset class="border">
            <legend>Concurso a Actualizar</legend>
            <div class="form-group">
                <label class="col-md-4 control-label" for="textinput">ID del Concurso</label>
                <div class="col-md-4">
                    <input id="txtID" readonly="readonly" runat="server" name="textinput" required="required" type="text" class="form-control input-md">
                    <asp:Label runat="server" ID="lbVerifica" CssClass="text-danger text-center" Visible="false">Este campo no debe quedar vacio</asp:Label>
                </div>
            </div>

        </fieldset>
        <br />
        <div class="col-md-4">
            <asp:Button ID="btnUpdate" CssClass="btn btn-danger" runat="server" Text="Actualizar Concurso" OnClick="actualizar_Click" />
        </div>

                   <br />
        
          </ContentTemplate>   
        </asp:UpdatePanel>

    </form>

</asp:Content>
