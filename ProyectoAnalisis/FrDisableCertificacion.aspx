<%@ Page Title="" Language="C#" MasterPageFile="~/IndexAdmin.Master" AutoEventWireup="true" CodeBehind="FrDisableCertificacion.aspx.cs" Inherits="ProyectoAnalisis.FrDisableCertificacion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form class="form-horizontal" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel2" runat="server" UpdateMode="Conditional">
            <ContentTemplate>
                <fieldset>
                    <asp:GridView ID="dgvCertificacion" runat="server" CssClass="table table-striped table-bordered" EnableTheming="True" OnSelectedIndexChanged="dgvCertificacion_SelectedIndexChanged" AllowPaging="True" OnPageIndexChanging="dgvCertificacion_PageIndexChanging" PageSize="5">
                        <Columns>
                            <asp:ButtonField CommandName="Select" Text="Seleccionar" />
                        </Columns>
                    </asp:GridView>


                    <!-- Form Name -->
                    <legend>Certificacion Seleccionada</legend>

                    <!-- Text input-->
                    <div class="form-group">
                        <label class="col-md-4 control-label" for="txtIdCertificacion">ID Certificacion</label>
                        <div class="col-md-4">
                            <input id="txtIdCertificacion" runat="server" name="txtIdCertificacion" type="text" readonly="true" class="form-control input-md">
                            <asp:RequiredFieldValidator ID="rfvId" runat="server" ControlToValidate="txtIdCertificacion" ErrorMessage="*ID requerido" ForeColor="Red" ValidationGroup="frCert"></asp:RequiredFieldValidator>

                        </div>
                    </div>

                    <!-- Text input-->
                    <div class="form-group">
                        <label class="col-md-4 control-label" for="txtCertificacion">Certificacion</label>
                        <div class="col-md-4">
                            <input id="txtCertificacion" runat="server" name="txtCertificacion" type="text" readonly="true" class="form-control input-md">
                            <asp:RequiredFieldValidator ID="rfvCert" runat="server" ControlToValidate="txtCertificacion" ErrorMessage="*Certificacion requerida" ForeColor="Red" ValidationGroup="frCert"></asp:RequiredFieldValidator>

                        </div>
                    </div>



                </fieldset>
            </ContentTemplate>
        </asp:UpdatePanel>
        <!-- Button -->
        <div class="form-group">
            <label class="col-md-4 control-label" for="singlebutton"></label>
            <div class="col-md-4">
                <asp:Button ID="singlebutton" name="singlebutton" runat="server" class="btn btn-primary" Text="Anular Certificacion" OnClick="singlebutton_Click" ValidationGroup="frCert" />
            </div>
        </div>
    </form>

</asp:Content>
