<%@ Page Title="" Language="C#" MasterPageFile="~/IndexAdmin.Master" AutoEventWireup="true" CodeBehind="FrEliminarConcurso.aspx.cs" Inherits="ProyectoAnalisis.FrEliminarConcurso" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">


    <form runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel2" runat="server">
            <ContentTemplate>
                <h4>Seleccione el concurso que desea Eliminar</h4>
                <hr />
                <br />
                <div>
                    <asp:GridView ID="gvMostrarConcurso" runat="server" CssClass="table table-striped table-bordered" EnableTheming="True" OnSelectedIndexChanged="gvMostrarConcurso_SelectedIndexChanged" AllowPaging="True" OnPageIndexChanging="gvMostrarConcurso_PageIndexChanging" PageSize="5">
                        <Columns>
                            <asp:ButtonField CommandName="Select" Text="Seleccionar" />
                        </Columns>
                    </asp:GridView>
                    <br />

                    <fieldset class="border">
                        <legend>Concurso a Eliminar</legend>
                        <div class="form-group">
                            <label class="col-md-4 control-label" for="textinput">ID del Concurso</label>
                            <div class="col-md-4">
                                <input id="txtID" readonly="readonly" runat="server" name="textinput" type="text" class="form-control input-md">
                                <asp:RequiredFieldValidator ID="rfvId" runat="server" ControlToValidate="txtID" ErrorMessage="*ID requerido" ForeColor="Red" ValidationGroup="frConcursoEliminar"></asp:RequiredFieldValidator>

                            </div>
                        </div>

                        <div class="form-group">
                            <label class="col-md-4 control-label" for="textinput">Codigo De Concurso</label>
                            <div class="col-md-4">
                                <input id="txtCodigo" readonly="readonly" runat="server" name="textinput" type="text" class="form-control input-md">
                                <asp:RequiredFieldValidator ID="rfvCod" runat="server" ControlToValidate="txtCodigo" ErrorMessage="*Codigo requerido" ForeColor="Red" ValidationGroup="frConcursoEliminar"></asp:RequiredFieldValidator>

                            </div>
                        </div>
                    </fieldset>

                </div>
            </ContentTemplate>
        </asp:UpdatePanel>
        <br />
        <div class="col-md-4">
            <asp:Button ID="eliminar" CssClass="btn btn-danger" runat="server" Text="Eliminar Concurso" OnClick="eliminar_Click" ValidationGroup="frConcursoEliminar" />
        </div>
        <br />
    </form>

</asp:Content>
