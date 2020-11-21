<%@ Page Title="" Language="C#" MasterPageFile="~/IndexAdmin.Master" AutoEventWireup="true" CodeBehind="FrAdminBusquedaAvanzada.aspx.cs" Inherits="ProyectoAnalisis.FrAdminBusquedaAvanzada" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    
          
<form class="form-horizontal" runat="server">
<fieldset>

<!-- Form Name -->
<legend>Busqueda Avanzada</legend>

<!-- Select Basic -->
<div class="form-group">
  <label class="col-md-4 control-label" for="selectbasic">Criterio de Busqueda</label>
  <div class="col-md-4">

       <asp:DropDownList ID="listaPuestos" Height="35px" Width="150px" runat="server" EnableViewState="true" Enabled="true" AppendDataBoundItems="true" CssClass="btn-outline-dark" >
           <asp:ListItem Text="Carrera" Value="Carrera"></asp:ListItem>
    <asp:ListItem Text="Cedula" Value="Cedula"></asp:ListItem>
       <asp:ListItem Text="Nombre" Value="Nombre"></asp:ListItem>
    <asp:ListItem Text="Apellidos" Value="Apellidos"></asp:ListItem>
       </asp:DropDownList>
            
      <br />

  </div>
</div>
<hr />
<!-- Text input-->
<div class="form-group">
  <label class="col-md-4 control-label" for="textinput">Valor</label>  
  <div class="col-md-5">
  <input id="textinput" runat="server" name="textinput" type="text" placeholder="Ingrese el valor de acuerdo a su criterio" class="form-control input-md">
    
  </div>
</div>

<!-- Button -->
<div class="form-group">
  <label class="col-md-4 control-label" for="singlebutton"></label>
  <div class="col-md-4">
    <asp:Button ID="btnFind" runat="server" Text="Buscar Ahora" CssClass="btn btn-primary" OnClick="btnFind_Click" />
  </div>
</div>

</fieldset>

 <div id="salvador" RUNAT="server" style="overflow: scroll" visible="false">
            <asp:GridView ID="gvMostrarPersonas"  runat="server" CssClass="table table-striped table-bordered dt-responsive nowrap" EnableTheming="True"  AllowPaging="True"  PageSize="5">
            </asp:GridView>
                </div>
    
</form>

           
           

</asp:Content>
