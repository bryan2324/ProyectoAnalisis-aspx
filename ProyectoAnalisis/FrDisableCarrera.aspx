<%@ Page Title="" Language="C#" MasterPageFile="~/IndexAdmin.Master" AutoEventWireup="true" CodeBehind="FrDisableCarrera.aspx.cs" Inherits="ProyectoAnalisis.FrDisableCarrera" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <form class="form-horizontal" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel2" runat="server" UpdateMode="Conditional">
            <ContentTemplate>
                <fieldset>
                    <asp:GridView ID="dgvCarrera" runat="server" CssClass="table table-striped table-bordered" EnableTheming="True" OnSelectedIndexChanged="dgvCarrera_SelectedIndexChanged" AllowPaging="True" OnPageIndexChanging="dgvCarrera_PageIndexChanging" PageSize="5">
                        <Columns>
                            <asp:ButtonField CommandName="Select" Text="Seleccionar" />
                        </Columns>
                    </asp:GridView>

                    <!-- Form Name -->
                    <legend>Carrera Seleccionada</legend>

                    <!-- Text input-->
                    <div class="form-group">
                        <label class="col-md-4 control-label" for="txtIdcarrera">ID Grado</label>
                        <div class="col-md-4">
                            <input id="txtIdcarrera" runat="server" name="txtIdcarrera" type="text" readonly="true" class="form-control input-md">
                            <asp:RequiredFieldValidator ID="rfvId" runat="server" ControlToValidate="txtIdcarrera" ErrorMessage="*ID requerido" ForeColor="Red" ValidationGroup="frCarrera"></asp:RequiredFieldValidator>

                        </div>
                    </div>

                    <!-- Text input-->
                    <div class="form-group">
                        <label class="col-md-4 control-label" for="txtCarrera">Grado</label>
                        <div class="col-md-4">
                            <input id="txtCarrera" runat="server" name="txtCarrera" type="text" readonly="true" class="form-control input-md">
                            <asp:RequiredFieldValidator ID="rfvCarrera" runat="server" ControlToValidate="txtCarrera" ErrorMessage="*Grado requerido" ForeColor="Red" ValidationGroup="frCarrera"></asp:RequiredFieldValidator>

                        </div>
                    </div>


                </fieldset>
            </ContentTemplate>
        </asp:UpdatePanel>
        <!-- Button -->
        <div class="form-group">
            <label class="col-md-4 control-label" for="singlebutton"></label>
            <div class="col-md-4">
                <asp:Button ID="singlebutton" name="singlebutton" runat="server" class="btn btn-primary" Text="Anular Carrera" OnClick="singlebutton_Click" ValidationGroup="frCarrera" />
            </div>
        </div>

    </form>

</asp:Content>
