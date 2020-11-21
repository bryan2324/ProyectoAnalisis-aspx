<%@ Page Title="" Language="C#" MasterPageFile="~/IndexAdmin.Master" AutoEventWireup="true" CodeBehind="FrDisableGrado.aspx.cs" Inherits="ProyectoAnalisis.FrDisableGrado" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <form class="form-horizontal" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel2" runat="server" UpdateMode="Conditional">
            <ContentTemplate>
                <fieldset>
                    <asp:GridView ID="dgvGrado" runat="server" CssClass="table table-striped table-bordered" EnableTheming="True" OnSelectedIndexChanged="dgvGrado_SelectedIndexChanged" AllowPaging="True" OnPageIndexChanging="dgvGrado_PageIndexChanging" PageSize="5">
                        <Columns>
                            <asp:ButtonField CommandName="Select" Text="Seleccionar" />
                        </Columns>
                    </asp:GridView>

                    <!-- Form Name -->
                    <legend>Grado Seleccionado</legend>

                    <!-- Text input-->
                    <div class="form-group">
                        <label class="col-md-4 control-label" for="txtidgrado">ID Grado</label>
                        <div class="col-md-4">
                            <input id="txtidgrado" runat="server" name="txtidgrado" type="text" readonly="true" class="form-control input-md">
                          <asp:RequiredFieldValidator ID="rfvId" runat="server" ControlToValidate="txtidgrado" ErrorMessage="*ID requerido" ForeColor="Red" ValidationGroup="frGrado"></asp:RequiredFieldValidator>

                        </div>
                    </div>

                    <!-- Text input-->
                    <div class="form-group">
                        <label class="col-md-4 control-label" for="txtGrado">Grado</label>
                        <div class="col-md-4">
                            <input id="txtGrado" runat="server" name="txtGrado" type="text" readonly="true" class="form-control input-md">
                           <asp:RequiredFieldValidator ID="rfvGrado" runat="server" ControlToValidate="txtidgrado" ErrorMessage="*Grado requerido" ForeColor="Red" ValidationGroup="frGrado"></asp:RequiredFieldValidator>

                        </div>
                    </div>

                </fieldset>
            </ContentTemplate>
        </asp:UpdatePanel>
        <!-- Button -->
        <div class="form-group">
            <label class="col-md-4 control-label" for="singlebutton"></label>
            <div class="col-md-4">
                <asp:Button ID="singlebutton" name="singlebutton" runat="server" class="btn btn-primary" Text="Anular Grado" OnClick="singlebutton_Click" ValidationGroup="frGrado"/>
            </div>
        </div>
    </form>

</asp:Content>
