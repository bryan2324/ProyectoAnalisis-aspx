<%@ Page Title="" Language="C#" MasterPageFile="~/IndexAdmin.Master" AutoEventWireup="true" CodeBehind="FrDisableLicencia.aspx.cs" Inherits="ProyectoAnalisis.FrDisableLicencia" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form class="form-horizontal" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel2" runat="server" UpdateMode="Conditional">
            <ContentTemplate>
                <fieldset>
                    <asp:GridView ID="dgvLicencia" runat="server" CssClass="table table-striped table-bordered" EnableTheming="True" OnSelectedIndexChanged="dgvLicencia_SelectedIndexChanged" AllowPaging="True" OnPageIndexChanging="dgvLicencia_PageIndexChanging" PageSize="5">
                        <Columns>
                            <asp:ButtonField CommandName="Select" Text="Seleccionar" />
                        </Columns>
                    </asp:GridView>


                    <!-- Form Name -->
                    <legend>Licencia Seleccionada</legend>

                    <!-- Text input-->
                    <div class="form-group">
                        <label class="col-md-4 control-label" for="txtidLicencia">ID Licencia</label>
                        <div class="col-md-4">
                            <input id="txtidLicencia" runat="server" name="txtidLicencia" type="text" readonly="true" class="form-control input-md">
                            <asp:RequiredFieldValidator ID="rfvId" runat="server" ControlToValidate="txtidLicencia" ErrorMessage="*ID requerido" ForeColor="Red" ValidationGroup="frLicen"></asp:RequiredFieldValidator>

                        </div>
                    </div>

                    <!-- Text input-->
                    <div class="form-group">
                        <label class="col-md-4 control-label" for="txtLicencia">Licencia</label>
                        <div class="col-md-4">
                            <input id="txtLicencia" runat="server" name="txtLicencia" type="text" readonly="true" class="form-control input-md">
                            <asp:RequiredFieldValidator ID="rfvLicen" runat="server" ControlToValidate="txtLicencia" ErrorMessage="*Licencia requerida" ForeColor="Red" ValidationGroup="frLicen"></asp:RequiredFieldValidator>

                        </div>
                    </div>

                </fieldset>
            </ContentTemplate>
        </asp:UpdatePanel>
        <!-- Button -->
        <div class="form-group">
            <label class="col-md-4 control-label" for="singlebutton"></label>
            <div class="col-md-4">
                <asp:Button ID="singlebutton" name="singlebutton" runat="server" class="btn btn-primary" Text="Anular Licencia" OnClick="singlebutton_Click" ValidationGroup="frLicen" />
            </div>
        </div>

    </form>

</asp:Content>
