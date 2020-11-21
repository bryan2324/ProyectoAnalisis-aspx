<%@ Page Title="" Language="C#" MasterPageFile="~/IndexAdmin.Master" AutoEventWireup="true" CodeBehind="FrDisableInfoLaboral.aspx.cs" Inherits="ProyectoAnalisis.FrDisableInfoLaboral" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <form class="form-horizontal" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel2" runat="server" UpdateMode="Conditional">
            <ContentTemplate>
                <fieldset>
                    <asp:GridView ID="dgvLaboral" runat="server" CssClass="table table-striped table-bordered" EnableTheming="True" OnSelectedIndexChanged="dgvLaboral_SelectedIndexChanged" AllowPaging="True" OnPageIndexChanging="dgvLaboral_PageIndexChanging" PageSize="5">
                        <Columns>
                            <asp:ButtonField CommandName="Select" Text="Seleccionar" />
                        </Columns>
                    </asp:GridView>


                    <!-- Form Name -->
                    <legend>Informacion laboral Seleccionada</legend>

                    <!-- Text input-->
                    <div class="form-group">
                        <label class="col-md-4 control-label" for="txtIdInfo">ID Informacion Laboral</label>
                        <div class="col-md-4">
                            <input id="txtIdInfo" runat="server" name="txtIdInfo" type="text" readonly="true" class="form-control input-md">
                            <asp:RequiredFieldValidator ID="rfvId" runat="server" ControlToValidate="txtIdInfo" ErrorMessage="*ID requerido" ForeColor="Red" ValidationGroup="frLabor"></asp:RequiredFieldValidator>

                        </div>
                    </div>

                    <!-- Text input-->
                    <div class="form-group">
                        <label class="col-md-4 control-label" for="txtProfesion">Profesion</label>
                        <div class="col-md-4">
                            <input id="txtProfesion" runat="server" name="txtProfesion" type="text" readonly="true" class="form-control input-md">
                            <asp:RequiredFieldValidator ID="rfvLabor" runat="server" ControlToValidate="txtProfesion" ErrorMessage="*Profesion requerida" ForeColor="Red" ValidationGroup="frLabor"></asp:RequiredFieldValidator>

                        </div>
                    </div>

                </fieldset>
            </ContentTemplate>
        </asp:UpdatePanel>

        <!-- Button -->
        <div class="form-group">
            <label class="col-md-4 control-label" for="singlebutton"></label>
            <div class="col-md-4">
                <asp:Button ID="singlebutton" name="singlebutton" runat="server" class="btn btn-primary" Text="Anular informacion Laboral" OnClick="singlebutton_Click" ValidationGroup="frLabor" />
            </div>
        </div>
    </form>

</asp:Content>

