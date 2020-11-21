<%@ Page Title="" Language="C#" MasterPageFile="~/IndexAdmin.Master" AutoEventWireup="true" CodeBehind="FrDisableNacionalidad.aspx.cs" Inherits="ProyectoAnalisis.FrDisableNacionalidad" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <form class="form-horizontal" runat="server">
                <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel2" runat="server" UpdateMode="Conditional">
            <ContentTemplate>
        <fieldset>
            <asp:GridView ID="dgvNacionalidad" runat="server" CssClass="table table-striped table-bordered" EnableTheming="True" OnSelectedIndexChanged="dgvNacionalidad_SelectedIndexChanged" AllowPaging="True" OnPageIndexChanging="dgvIdiomas_PageIndexChanging" PageSize="5">
                <Columns>
                    <asp:ButtonField CommandName="Select" Text="Seleccionar" />
                </Columns>
            </asp:GridView>


            <!-- Form Name -->
            <legend>Nacionalidad Seleccionada</legend>

            <!-- Text input-->
            <div class="form-group">
                <label class="col-md-4 control-label" for="txtididioma">ID Nacionalidad</label>
                <div class="col-md-4">
                    <input id="txtidNacionalidad" runat="server" name="txtidNacionalidad" type="text" readonly="true" class="form-control input-md">
                    <asp:RequiredFieldValidator ID="rfvId" runat="server" ControlToValidate="txtidNacionalidad" ErrorMessage="*ID requerido" ForeColor="Red" ValidationGroup="frNacionalidad"></asp:RequiredFieldValidator>

                </div>
            </div>

            <!-- Text input-->
            <div class="form-group">
                <label class="col-md-4 control-label" for="txtIdioma">Nacionalidad</label>
                <div class="col-md-4">
                    <input id="txtNacionalidad" runat="server" name="txtNacionalidad" type="text" readonly="true" class="form-control input-md">
                <asp:RequiredFieldValidator ID="rfvNacio" runat="server" ControlToValidate="txtNacionalidad" ErrorMessage="*Nacionalidad requerida" ForeColor="Red" ValidationGroup="frNacionalidad"></asp:RequiredFieldValidator>

                </div>
            </div>

     

        </fieldset>
                            </ContentTemplate>
        </asp:UpdatePanel>
               <!-- Button -->
            <div class="form-group">
                <label class="col-md-4 control-label" for="singlebutton"></label>
                <div class="col-md-4">
                    <asp:Button ID="singlebutton" name="singlebutton" runat="server" class="btn btn-primary" Text="Anular Nacionalidad" OnClick="singlebutton_Click" ValidationGroup="frNacionalidad" />
                </div>
            </div>
    </form>

</asp:Content>
