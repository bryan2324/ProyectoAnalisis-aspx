<%@ Page Title="" Language="C#" MasterPageFile="~/IndexAdmin.Master" AutoEventWireup="true" CodeBehind="FrDisableIdioma.aspx.cs" Inherits="ProyectoAnalisis.FrDisableIdioma" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <form class="form-horizontal" runat="server">
                <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel2" runat="server" UpdateMode="Conditional">
            <ContentTemplate>
        <fieldset>
            <asp:GridView ID="dgvIdiomas" runat="server" CssClass="table table-striped table-bordered" EnableTheming="True" OnSelectedIndexChanged="dgvIdiomas_SelectedIndexChanged" AllowPaging="True" OnPageIndexChanging="dgvIdiomas_PageIndexChanging" PageSize="5">
                <Columns>
                    <asp:ButtonField CommandName="Select" Text="Seleccionar" />
                </Columns>
            </asp:GridView>


            <!-- Form Name -->
            <legend>Idioma Seleccionado</legend>

            <!-- Text input-->
            <div class="form-group">
                <label class="col-md-4 control-label" for="txtididioma">ID Idioma</label>
                <div class="col-md-4">
                    <input id="txtididioma" runat="server" name="txtididioma" type="text" readonly="true" class="form-control input-md">
                      <asp:RequiredFieldValidator ID="rfvId" runat="server" ControlToValidate="txtididioma" ErrorMessage="*ID requerido" ForeColor="Red" ValidationGroup="frIdioma"></asp:RequiredFieldValidator>

                </div>
            </div>

            <!-- Text input-->
            <div class="form-group">
                <label class="col-md-4 control-label" for="txtIdioma">Idioma</label>
                <div class="col-md-4">
                    <input id="txtIdioma" runat="server" name="txtIdioma" type="text" readonly="true" class="form-control input-md">
                   <asp:RequiredFieldValidator ID="rfvIdioma" runat="server" ControlToValidate="txtIdioma" ErrorMessage="*Idioma requerido" ForeColor="Red" ValidationGroup="frIdioma"></asp:RequiredFieldValidator>

                </div>
            </div>

            <!-- Button -->
   

        </fieldset>
                            </ContentTemplate>
        </asp:UpdatePanel>
                 <div class="form-group">
                <label class="col-md-4 control-label" for="singlebutton"></label>
                <div class="col-md-4">
                    <asp:Button ID="singlebutton" name="singlebutton" runat="server" class="btn btn-primary" Text="Anular Idioma" OnClick="singlebutton_Click" ValidationGroup="frIdioma"/>
                </div>
            </div>
    </form>

</asp:Content>
