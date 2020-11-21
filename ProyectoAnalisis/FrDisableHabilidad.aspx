<%@ Page Title="" Language="C#" MasterPageFile="~/IndexAdmin.Master" AutoEventWireup="true" CodeBehind="FrDisableHabilidad.aspx.cs" Inherits="ProyectoAnalisis.FrDisableHabilidad" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <form class="form-horizontal" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel2" runat="server" UpdateMode="Conditional">
            <ContentTemplate>

                <fieldset>
                    <asp:GridView ID="dgvHabilidad" runat="server" CssClass="table table-striped table-bordered" EnableTheming="True" OnSelectedIndexChanged="dgvHabilidad_SelectedIndexChanged" AllowPaging="True" OnPageIndexChanging="dgvHabilidad_PageIndexChanging" PageSize="5">
                        <Columns>
                            <asp:ButtonField CommandName="Select" Text="Seleccionar" />
                        </Columns>
                    </asp:GridView>


                    <!-- Form Name -->
                    <legend>Habilidad Seleccionada</legend>

                    <!-- Text input-->
                    <div class="form-group">
                        <label class="col-md-4 control-label" for="txtIdHabilidad">ID Habilidad</label>
                        <div class="col-md-4">
                            <input id="txtIdHabilidad" runat="server" name="txtIdHabilidad" type="text" readonly="true" class="form-control input-md">
                            <asp:RequiredFieldValidator ID="rfvId" runat="server" ControlToValidate="txtIdHabilidad" ErrorMessage="*ID requerido" ForeColor="Red" ValidationGroup="frHabilidad"></asp:RequiredFieldValidator>

                        </div>
                    </div>

                    <!-- Text input-->
                    <div class="form-group">
                        <label class="col-md-4 control-label" for="txtHabilidad">Habilidad</label>
                        <div class="col-md-4">
                            <input id="txtHabilidad" runat="server" name="txtHabilidad" type="text" readonly="true" class="form-control input-md">
                            <asp:RequiredFieldValidator ID="rfvHab" runat="server" ControlToValidate="txtHabilidad" ErrorMessage="*Habilidad requerida" ForeColor="Red" ValidationGroup="frHabilidad"></asp:RequiredFieldValidator>

                        </div>
                    </div>



                </fieldset>
            </ContentTemplate>
        </asp:UpdatePanel>
        <!-- Button -->
        <div class="form-group">
            <label class="col-md-4 control-label" for="singlebutton"></label>
            <div class="col-md-4">
                <asp:Button ID="singlebutton" name="singlebutton" runat="server" class="btn btn-primary" Text="Anular Idioma" OnClick="singlebutton_Click" ValidationGroup="frHabilidad" />
            </div>
        </div>
    </form>

</asp:Content>
