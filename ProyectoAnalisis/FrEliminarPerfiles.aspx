<%@ Page Title="" Language="C#" MasterPageFile="~/IndexAdmin.Master" AutoEventWireup="true" CodeBehind="FrEliminarPerfiles.aspx.cs" Inherits="ProyectoAnalisis.FrEliminarPerfiles" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <form runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel2" runat="server">
            <ContentTemplate>
                <h4>Seleccione el Perfil que desea Eliminar</h4>
                <hr />
                <br />
                <div>
                    <asp:GridView ID="gvMostrarPersonas" runat="server" CssClass="table table-striped table-bordered" EnableTheming="True" OnSelectedIndexChanged="gvMostrarPersonas_SelectedIndexChanged" AllowPaging="True" OnPageIndexChanging="gvMostrarPersonas_PageIndexChanging" PageSize="5">
                        <Columns>
                            <asp:ButtonField CommandName="Select" Text="Seleccionar" />
                        </Columns>
                    </asp:GridView>
                    <br />
                    <fieldset class="border">
                        <legend>Perfil a Eliminar</legend>
                        <div class="form-group">
                            <label class="col-md-4 control-label" for="textinput">ID del Usuario</label>
                            <div class="col-md-4">
                                <input id="txtID" readonly="readonly" runat="server" name="textinput" type="text" class="form-control input-md">
                                <asp:RequiredFieldValidator ID="rfvId" runat="server" ControlToValidate="txtID" ErrorMessage="*ID requerido" ForeColor="Red" ValidationGroup="frPerfilEliminar"></asp:RequiredFieldValidator>

                            </div>
                        </div>

                        <div class="form-group">
                            <label class="col-md-4 control-label" for="textinput">Nombre</label>
                            <div class="col-md-4">
                                <input id="txtNombre" readonly="readonly" runat="server" name="textinput" type="text" class="form-control input-md">
                                <asp:RequiredFieldValidator ID="rfvNombre" runat="server" ControlToValidate="txtNombre" ErrorMessage="*Nombre requerido" ForeColor="Red" ValidationGroup="frPerfilEliminar"></asp:RequiredFieldValidator>

                            </div>
                        </div>

                        <div class="form-group">
                            <label class="col-md-4 control-label" for="textinput">Apellidos</label>
                            <div class="col-md-4">
                                <input id="txtapellidos" readonly="readonly" runat="server" name="textinput" type="text" class="form-control input-md">
                                <asp:RequiredFieldValidator ID="rfvApellidos" runat="server" ControlToValidate="txtapellidos" ErrorMessage="*Apellidos requeridos" ForeColor="Red" ValidationGroup="frPerfilEliminar"></asp:RequiredFieldValidator>

                            </div>
                        </div>

                    </fieldset>


                </div>
            </ContentTemplate>
        </asp:UpdatePanel>
        <br />
        <div class="col-md-4">
            <asp:Button ID="eliminar" CssClass="btn btn-danger" runat="server" Text="Eliminar Perfil" OnClick="eliminar_Click" ValidationGroup="frPerfilEliminar" />
        </div>
        <br />
    </form>


</asp:Content>
