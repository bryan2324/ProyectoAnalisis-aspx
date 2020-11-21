<%@ Page Title="" Language="C#" MasterPageFile="~/IndexAdmin.Master" AutoEventWireup="true" CodeBehind="FrCambiarRolUsuarios.aspx.cs" Inherits="ProyectoAnalisis.FrCambiarRolUsuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>



<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel2" runat="server">
            <ContentTemplate>

                <h4>Perfiles</h4>
        <hr />
        <br />
        <div style="overflow: scroll">
            <asp:GridView ID="gvMostrarUsuarios" runat="server" CssClass="table table-striped table-bordered dt-responsive nowrap" EnableTheming="True" AllowPaging="True" PageSize="5" OnSelectedIndexChanged="gvMostrarUsuarios_SelectedIndexChanged" >
                <Columns>
                    <asp:ButtonField CommandName="Select" Text="Seleccionar" />
                </Columns>
            </asp:GridView>
        </div>

        <fieldset class="border">
            <legend>
                <br />
                Usuario a Modificar</legend>
              <div class="form-group">
                <label class="col-md-4 control-label" for="textinput">ID de Usuario</label>
                <div class="col-md-4">
                    <input id="txtCedula" readonly="readonly" runat="server" name="textinput" required="required" type="text" class="form-control input-md">
                    <asp:Label runat="server" ID="Label1" CssClass="text-danger text-center" Visible="false">Este campo no debe quedar vacio</asp:Label>
                </div>
            </div>

            <div class="form-group">
                <label class="col-md-4 control-label" for="textinput">Id Rol Usuario Nuevo</label>
                <div class="col-md-4">
                    <input id="txtRol" runat="server" name="textinput" required="required" type="text" class="form-control input-md">
                    <asp:Label runat="server" ID="lbVerifica" CssClass="text-danger text-center" Visible="false">Este campo no debe quedar vacio</asp:Label>
                </div>
            </div>

        </fieldset>
        <br />
        <div class="col-md-4">
            <asp:Button ID="btnUpdate" CssClass="btn btn-danger" runat="server" Text="Cambiar Rol" OnClick="btnUpdate_Click"  />
        </div>
                <br />
        <p>
            Rol 1= Administrador
        </p>
                   <p>
                       Rol 2= Usuario concursante
                </p>
                   <br />
        
          </ContentTemplate>   
        </asp:UpdatePanel>

    </form>

</asp:Content>
