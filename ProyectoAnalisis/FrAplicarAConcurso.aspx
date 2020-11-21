<%@ Page Title="" Language="C#" MasterPageFile="~/Index.Master" AutoEventWireup="true" CodeBehind="FrAplicarAConcurso.aspx.cs" Inherits="ProyectoAnalisis.FrAplicarAConcurso" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">


    <form runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel2" runat="server" UpdateMode="Conditional">
            <ContentTemplate>
                
                <h4>Seleccione el concurso al que desea aplicar</h4>
                <hr />
                <br />
                <div>
                    <asp:GridView ID="gvMostrarConcurso" runat="server" CssClass="table table-striped table-bordered" EnableTheming="True" OnSelectedIndexChanged="gvMostrarConcurso_SelectedIndexChanged1" AllowPaging="True" OnPageIndexChanging="gvMostrarConcurso_PageIndexChanging" PageSize="6">
                        <Columns>
                            <asp:ButtonField CommandName="Select" Text="Seleccionar" />
                        </Columns>
                    </asp:GridView>
                    <br />

                    <fieldset class="border">
                        <legend>Concurso a Aplicar</legend>
                        <div class="form-group">
                            <label class="col-md-4 control-label" for="textinput">ID del Concurso</label>
                            <div class="col-md-4">
                                <input id="txtID" readonly="readonly" runat="server" name="textinput" type="text" required="required" class="form-control input-md">
                                <asp:RequiredFieldValidator ID="rfvID" runat="server" ControlToValidate="txtID" ErrorMessage="*ID requerido" ForeColor="Red" ValidationGroup="frConcurso"></asp:RequiredFieldValidator>

                            </div>
                        </div>

                        <div class="form-group">
                            <label class="col-md-4 control-label" for="textinput">Codigo De Concurso</label>
                            <div class="col-md-4">
                                <input id="txtCodigo" readonly="readonly" runat="server" name="textinput" type="text" required="required" class="form-control input-md">
                                <asp:RequiredFieldValidator ID="rfvCod" runat="server" ControlToValidate="txtCodigo" ErrorMessage="*Codigo requerido" ForeColor="Red" ValidationGroup="frConcurso"></asp:RequiredFieldValidator>

                            </div>
                        </div>
                    </fieldset>

                </div>
            </ContentTemplate>
        </asp:UpdatePanel>
        <br />
        <div class="col-md-4">
            <asp:Button ID="aplicar" CssClass="btn btn-danger" runat="server" Text="Aplicar a Concurso" OnClick="aplicar_Click" ValidationGroup="frConcurso" />
            <br />
            <asp:Label runat="server" ID="lbApli" CssClass="text-danger text-center" Visible="false">**Debe tener un perfil registrado para aplicar</asp:Label>
        </div>
    </form>
</asp:Content>
