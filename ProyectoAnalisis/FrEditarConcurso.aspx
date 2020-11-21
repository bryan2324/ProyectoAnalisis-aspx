<%@ Page Title="" Language="C#" MasterPageFile="~/IndexAdmin.Master" AutoEventWireup="true" CodeBehind="FrEditarConcurso.aspx.cs" Inherits="ProyectoAnalisis.FrEditarConcurso" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/estilo.css" rel="stylesheet" />

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <form runat="server" id="Formulario1" class="form-group" cols="20">
        <asp:ScriptManager ID="ScriptManager1" runat="server" LoadScriptsBeforeUI="true"
            EnablePartialRendering="true">
        </asp:ScriptManager>
        <h2>Actualizar Concurso</h2>
        <h3 class="text-info">Informacion del concurso</h3>
        <hr />
        <div class="form-label-group form-group">
            <input type="text" id="codConcursoFront" runat="server" class="input-group-sm" required="required" autofocus="autofocus">
            <label for="codConcursoFront">Codigo de concurso</label>
            <asp:RequiredFieldValidator ID="rfvCodConcurso" runat="server" ControlToValidate="codConcursoFront" ErrorMessage="*Codigo requerido" ForeColor="Red" ValidationGroup="frConcurso"></asp:RequiredFieldValidator>

        </div>
        <br />
        <%--Para evitar recargar todo la pagina al seleccionar un requisito se usa update panel--%>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
            <ContentTemplate>
                <label>Puesto de trabajo</label>
                <asp:DropDownList ID="listaPuestos" Height="35px" Width="150px" runat="server" EnableViewState="true" Enabled="true" AppendDataBoundItems="true" CssClass="btn-outline-dark" />
                <asp:Button ID="addPuesto" runat="server" Text="Agregar mas puestos" CssClass="btn-outline-secondary" OnClick="addPuesto_Click" />

                <asp:Panel ID="paPuesto" runat="server" Style="display: none" CssClass="modalPopup">

                    <div class="modal-content">
                        <div class="modal-header">

                            <h4 class="modal-title" style="text-align: center">Nuevo puesto</h4>
                        </div>
                        <div class="modal-body">
                            <asp:Label ID="Label2" runat="server" Text="Agregar nuevo puesto"></asp:Label>
                            <asp:TextBox ID="txtPuesto" runat="server"></asp:TextBox>
                            <br />

                            <asp:Label runat="server" ID="labelVerificarPuesto" CssClass="text-danger text-center" Visible="false">Ya existe este puesto</asp:Label>
                        </div>
                        <div class="modal-footer">
                            <asp:Button ID="btnAceptarP" UseSubmitBehavior="false" runat="server" Text="Agregar Puesto" OnClick="btnAceptarP_Click" />
                            <asp:Button ID="btnCancelarP" UseSubmitBehavior="false" runat="server" Text="Cancelar" OnClick="btnCancelarP_Click" />
                        </div>
                    </div>
                </asp:Panel>
                <ajaxToolkit:ModalPopupExtender ID="mpePuesto" runat="server"
                    TargetControlID="addPuesto"
                    OkControlID="btnAceptarP"
                    OnOkScript="_doPostBack('btnAceptarP' , '')"
                    CancelControlID="btnCancelarP"
                    OnCancelScript="_doPostBack('btnCancelarP' , '')"
                    PopupControlID="paPuesto"
                    BackgroundCssClass="ModalPopupFondo">
                </ajaxToolkit:ModalPopupExtender>
            </ContentTemplate>
        </asp:UpdatePanel>
        <br />
        <br />
        <asp:UpdatePanel ID="UpdatePanel2" runat="server">

            <ContentTemplate>

                <fieldset>
                    <asp:GridView ID="dgvrequisitos" runat="server" CssClass="table table-striped table-bordered" EnableTheming="True" OnSelectedIndexChanged="dgvIdiomas_SelectedIndexChanged" AllowPaging="True" OnPageIndexChanging="dgvrequisitos_PageIndexChanging" PageSize="5">
                        <Columns>
                            <asp:ButtonField CommandName="Select" Text="Seleccionar" />
                        </Columns>
                    </asp:GridView>


                    <!-- Form Name -->
                    <legend>Requisitos</legend>

                    <!-- Text input-->
                    <div class="form-group">
                        <label class="col-md-4 control-label" for="txtididioma">ID Requisitos</label>
                        <div class="col-md-4">
                            <input id="txtReq" runat="server" name="txtididioma" type="text" readonly="true" required="required" class="form-control input-md">
                            <asp:RequiredFieldValidator ID="rfvIDRequisito" runat="server" ControlToValidate="txtReq" ErrorMessage="*id de requisito es requerido" ForeColor="Red" ValidationGroup="frConcurso"></asp:RequiredFieldValidator>

                        </div>
                    </div>


                    <!-- Button -->
                    <div class="form-group">
                        <label class="col-md-4 control-label" for="singlebutton"></label>
                        <div class="col-md-4">
                            <asp:Button ID="addRequi" runat="server" Text="Agregar requisitos" CssClass="btn btn-primary" OnClick="addRequi_Click" />
                        </div>
                    </div>

                </fieldset>


            </ContentTemplate>
        </asp:UpdatePanel>

        <br />

        <label>Fecha de Inicio del concurso</label><br />
        <asp:TextBox TextMode="Date" Text='<%#  Convert.ToDateTime(Eval("dateTime")).ToString("yyyy/MM/dd") %>' ID="fechaIniFront" required="required" runat="server" Width="179px" />
        <br />
        <br />
        <label>Fecha de Cierre del Concurso</label><br />
        <asp:TextBox TextMode="Date" Text='<%#  Convert.ToDateTime(Eval("dateTime")).ToString("yyyy/MM/dd") %>' ID="fechaCieFront" required="required" runat="server" Width="179px" />
        <br />
        <asp:CompareValidator ID="CompareValidator1" ValidationGroup="frConcurso" ForeColor="Red" runat="server" ControlToValidate="fechaIniFront"
            ControlToCompare="fechaCieFront" Operator="LessThanEqual" Type="Date" ErrorMessage="La fecha de cierre no puede ser antes que la de inicio"></asp:CompareValidator>
        <br />
        <div class="form-label-group form-group">
            <input type="text" id="descripcionFront" runat="server" class="input-group-sm" required="required">
            <label for="descripcionFront">Descripcion del Concurso</label>
            <asp:RequiredFieldValidator ID="rfvDescripcion" runat="server" ControlToValidate="descripcionFront" ErrorMessage="*La descripcion es requerida" ForeColor="Red" ValidationGroup="frConcurso"></asp:RequiredFieldValidator>

        </div>
        <br />
        <%--<label>Descripcion general del concurso</label><br />--%>
        <%--<textarea id="txtDescripcion" name="S1" rows="6" style="resize: none" cols="60" autofocus="autofocus" maxlength="150"></textarea>--%>

        <asp:Button ID="AgregarPerfilDelConcurso" runat="server" Text="Editar Concurso" CssClass="btn-primary btn-lg " OnClick="AgregarPerfilDelConcurso_Click" ValidationGroup="frConcurso" />
    </form>
    <br />
    <asp:Label ID="labelMensaje" runat="server" Text="Perfil del Concurso editado exitosamente" CssClass="alert-success" Visible="false"></asp:Label>
    <br />

</asp:Content>
