<%@ Page Title="" Language="C#" MasterPageFile="~/IndexAdmin.Master" AutoEventWireup="true" CodeBehind="FrDisableInfoInstitucion.aspx.cs" Inherits="ProyectoAnalisis.FrDisableInfoInstitucion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <form class="form-horizontal" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel2" runat="server" UpdateMode="Conditional">
            <ContentTemplate>
                <fieldset>
                    <asp:GridView ID="dgvInstitucion" runat="server" CssClass="table table-striped table-bordered" EnableTheming="True" OnSelectedIndexChanged="dgvInstitucion_SelectedIndexChanged" AllowPaging="True" OnPageIndexChanging="dgvInstitucion_PageIndexChanging" PageSize="5">
                        <Columns>
                            <asp:ButtonField CommandName="Select" Text="Seleccionar" />
                        </Columns>
                    </asp:GridView>


                    <!-- Form Name -->
                    <legend>Institucion Seleccionada</legend>

                    <!-- Text input-->
                    <div class="form-group">
                        <label class="col-md-4 control-label" for="txtIdInsti">ID Institucion</label>
                        <div class="col-md-4">
                            <input id="txtIdInsti" runat="server" name="txtIdInsti" type="text" readonly="true" class="form-control input-md">
                            <asp:RequiredFieldValidator ID="rfvId" runat="server" ControlToValidate="txtIdInsti" ErrorMessage="*ID requerido" ForeColor="Red" ValidationGroup="frInst"></asp:RequiredFieldValidator>

                        </div>
                    </div>

                    <!-- Text input-->
                    <div class="form-group">
                        <label class="col-md-4 control-label" for="txtInstitucion">Institucion</label>
                        <div class="col-md-4">
                            <input id="txtInstitucion" runat="server" name="txtInstitucion" type="text" readonly="true" class="form-control input-md">
                            <asp:RequiredFieldValidator ID="rfvInsti" runat="server" ControlToValidate="txtInstitucion" ErrorMessage="*Institucion requerida" ForeColor="Red" ValidationGroup="frInst"></asp:RequiredFieldValidator>

                        </div>
                    </div>



                </fieldset>
            </ContentTemplate>
        </asp:UpdatePanel>
        <!-- Button -->
        <div class="form-group">
            <label class="col-md-4 control-label" for="singlebutton"></label>
            <div class="col-md-4">
                <asp:Button ID="singlebutton" name="singlebutton" runat="server" class="btn btn-primary" Text="Anular Institucion" OnClick="singlebutton_Click" ValidationGroup="frInst" />
            </div>
        </div>
    </form>

</asp:Content>
