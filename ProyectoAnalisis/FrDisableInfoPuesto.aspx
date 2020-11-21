<%@ Page Title="" Language="C#" MasterPageFile="~/IndexAdmin.Master" AutoEventWireup="true" CodeBehind="FrDisableInfoPuesto.aspx.cs" Inherits="ProyectoAnalisis.FrDisableInfoPuesto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <form class="form-horizontal" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel2" runat="server" UpdateMode="Conditional">
            <ContentTemplate>
                <fieldset>
                    <asp:GridView ID="dgvPuesto" runat="server" CssClass="table table-striped table-bordered" EnableTheming="True" OnSelectedIndexChanged="dgvPuesto_SelectedIndexChanged" AllowPaging="True" OnPageIndexChanging="dgvPuesto_PageIndexChanging" PageSize="6">
                        <Columns>
                            <asp:ButtonField CommandName="Select" Text="Seleccionar" />
                        </Columns>
                    </asp:GridView>


                    <!-- Form Name -->
                    <legend>Puesto Seleccionado</legend>

                    <!-- Text input-->
                    <div class="form-group">
                        <label class="col-md-4 control-label" for="txtIdPuesto">ID Puesto</label>
                        <div class="col-md-4">
                            <input id="txtIdPuesto" runat="server" name="txtIdPuesto" type="text" readonly="true" class="form-control input-md">
                            <asp:RequiredFieldValidator ID="rfvId" runat="server" ControlToValidate="txtIdPuesto" ErrorMessage="*ID requerido" ForeColor="Red" ValidationGroup="frPuesto"></asp:RequiredFieldValidator>

                        </div>
                    </div>

                    <!-- Text input-->
                    <div class="form-group">
                        <label class="col-md-4 control-label" for="txtPuesto">Puesto</label>
                        <div class="col-md-4">
                            <input id="txtPuesto" runat="server" name="txtPuesto" type="text" readonly="true" class="form-control input-md">
                            <asp:RequiredFieldValidator ID="rfvPuesto" runat="server" ControlToValidate="txtPuesto" ErrorMessage="*Puesto requerido" ForeColor="Red" ValidationGroup="frPuesto"></asp:RequiredFieldValidator>

                        </div>
                    </div>

                </fieldset>
            </ContentTemplate>
        </asp:UpdatePanel>
        <!-- Button -->
        <div class="form-group">
            <label class="col-md-4 control-label" for="singlebutton"></label>
            <div class="col-md-4">
                <asp:Button ID="singlebutton" name="singlebutton" runat="server" class="btn btn-primary" Text="Anular Puesto" OnClick="singlebutton_Click" ValidationGroup="frPuesto" />
            </div>
        </div>
    </form>

</asp:Content>
