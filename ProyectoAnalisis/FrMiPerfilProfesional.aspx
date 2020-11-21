<%@ Page Title="" Language="C#" MasterPageFile="~/Index.Master" AutoEventWireup="true" CodeBehind="FrMiPerfilProfesional.aspx.cs" Inherits="ProyectoAnalisis.FrMiPerfilProfesional" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
        <form runat="server" id="Formulario1" class="form-group">
        <h2>Mi Perfil</h2>

<br />
        <hr />
<h3 class="text-info">Informacion Personal</h3>
        <hr />
        <div class="form-label-group form-group">
            <input type="text" id="nombreFront" runat="server" class="input-group-sm" autofocus="autofocus" readonly="true">
            <label for="cedula">Nombre</label>
        </div>
        <br />
        <div class="form-label-group form-group">
            <input type="text" id="apellidosFront"  runat="server" class="input-group-lg" autofocus="autofocus" readonly="true">
            <label for="cedula">Apellidos</label>
        </div>

        <br />
        <label>Fecha de Nacimiento</label><br />
        <asp:TextBox TextMode="DateTime" ID="fechaFront" runat="server" Width="179px" readonly="true"/>
        <br />
        <br />
        <div class="form-label-group form-group">
            <input type="Number" id="telefonoFront" runat="server" class="input-group-lg"
                autofocus="autofocus" readonly="true">
            <label for="cedula">Telefono</label>
            <br />
        </div>
        <br />
        <div class="form-label-group form-group">
            <input type="text" id="DireccionFront" readonly="true" runat="server" class="input-group-lg" autofocus="autofocus">
            <label for="cedula">Direccion</label>
        </div>

        <br />
     
        <label>Nacionalidades</label>
        <br />
        <asp:DropDownList ID="lista1" Enabled="False"  Height="35px" Width="150px" runat="server" EnableViewState="true"  AppendDataBoundItems="true" CssClass="btn-outline-dark"/>
       
        <br />
        <br />
        <label>Genero</label>
        <br />
        <asp:DropDownList ID="lista2" readonly="true" CssClass="btn-outline-dark" Height="35px" Width="150px" runat="server" EnableViewState="true" Enabled="false" AppendDataBoundItems="true" />
           
        <br />
        <br />
      
    

 

<hr />
        <h3 class="text-info">Informacion sobre estudios</h3>
        <hr />

      <label>Institucion en la que estudio </label>
        <br />
        <asp:DropDownList ID="lista3" readonly="true" Height="35px" CssClass="btn-outline-dark" runat="server" Width="150px" EnableViewState="true" Enabled="false" AppendDataBoundItems="true"  />
      
        <br />
        <br />
           <label>Carrera</label>
        <br />
        <asp:DropDownList ID="lista4" readonly="true" Height="35px" runat="server" CssClass="btn-outline-dark" Width="150px" EnableViewState="true" Enabled="true" AppendDataBoundItems="true"  />
    
        <br />
        <br />
        <label>Grado de Estudio</label>
        <br />
        <asp:DropDownList ID="lista5" readonly="true" Height="35px" runat="server" CssClass="btn-outline-dark" Width="150px" EnableViewState="true" Enabled="true" AppendDataBoundItems="true" />
      
        <br />
        <br />

        <hr />
        <h3 class="text-info">Informacion Laboral anterior</h3>
        <hr />
          <div class="form-label-group form-group">
            <input type="text" id="txtProfesion" readonly="true" runat="server" class="input-group-lg" autofocus="autofocus">
            <label for="txtProfesion">Profesion</label>
        </div>
      <br />
          <div class="form-label-group form-group">
            <input type="number" id="txtExperiencia" runat="server" readonly="true" class="input-group-lg" autofocus="autofocus">
            <label for="txtExperiencia">Años de experiencia</label>
        </div>
        <br />
        <hr />
        <h3 class="text-info">Certificaciones</h3>
        <hr />

         <div class="form-label-group form-group">
            <input type="text" id="txtCertificacion" runat="server" readonly="true" class="input-group-lg" autofocus="autofocus">
            <label for="txtCertificacion">Certificación</label>

              <asp:TextBox TextMode="DateTime" ID="fechaCerti" runat="server" Width="179px" />
        </div>
        <br />
         <hr />
        <h3 class="text-info">Habilidades</h3>
        <hr />
        <br />
         <div class="form-label-group form-group">
            <input type="text" id="txtHabilidades" runat="server" readonly="true" class="input-group-lg" autofocus="autofocus">
            <label for="txtHabilidades">Habilidad</label>
        </div>
        <br />
        <h3 class="text-info">Informacion Adicional</h3>
        <hr />
 
        <br />
     
        <label>Segundo Idioma</label>
        <br />
        <asp:DropDownList ID="ListaIdiomas" readonly="true" Height="35px" Width="150px" CssClass="btn-outline-dark  " runat="server" EnableViewState="true" Enabled="false" AppendDataBoundItems="true" />
     
        <br /><br />
           <div class="form-label-group form-group">
            <input type="text" id="TxtIdioma" runat="server" readonly="true" class="input-group-sm" autofocus="autofocus">
            <label for="cedula">Nivel del Segundo Idioma</label>
        </div>
        <br />
        <label>Licencia</label>
        <br />
        <asp:DropDownList ID="ListaLicencias" readonly="true" Height="35px" Width="150px" CssClass="btn-outline-dark"  runat="server" EnableViewState="true" Enabled="false" AppendDataBoundItems="true" />
     
           
        <br />
        <br />

        <hr />
        <asp:Button ID="EditarPerfil"   runat="server" Text="Actualizar Perfil" CssClass="btn-primary btn-lg " Visible="true" OnClick="EditarPerfil_Click" />
        <br />



       </form>

       
      <asp:Label ID="Label2" runat="server"  Text="Ya tiene un perfil almacenado en el sistema" CssClass="alert-success" Visible="false"></asp:Label>
    
    <asp:Label ID="Label1" runat="server"  Text="Perfil Agregado exitosamente" CssClass="alert-success" Visible="false"></asp:Label>

</asp:Content>
