<%@ Page Title="" Language="C#" MasterPageFile="~/Index.Master" AutoEventWireup="true" CodeBehind="FrEditarMiPerfil.aspx.cs" Inherits="ProyectoAnalisis.FrEditarMiPerfil" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <form runat="server" id="Formulario1" class="form-group">
        <h2>Actualizar Mi Perfil</h2>

        <br />
        <hr />
        <h3 class="text-info">Informacion Personal</h3>
        <hr />
        <div class="form-label-group form-group">
            <input type="text" id="nombreFront" runat="server" class="input-group-sm" required="required" autofocus="autofocus">
            <label for="cedula">Nombre</label>
            <asp:RequiredFieldValidator ID="rfvNombre" runat="server" ControlToValidate="nombreFront" ErrorMessage="*Nombre requerido" ForeColor="Red" ValidationGroup="frPerfil"></asp:RequiredFieldValidator>

        </div>
        <br />
        <div class="form-label-group form-group">
            <input type="text" id="apellidosFront" runat="server" class="input-group-lg" autofocus="autofocus">
            <label for="cedula">Apellidos</label>
            <asp:RequiredFieldValidator ID="rfvApellidos" runat="server" ControlToValidate="apellidosFront" ErrorMessage="*Apellidos requeridos" ForeColor="Red" ValidationGroup="frPerfil"></asp:RequiredFieldValidator>

        </div>

        <br />
        <label>Fecha de Nacimiento</label><br />
        <asp:TextBox TextMode="Date" Text='<%#  Convert.ToDateTime(Eval("dateTime")).ToString("yyyy/MM/dd") %>' ID="fechaFront" required="required" runat="server" Width="179px" />
        <asp:CompareValidator ID="cvFecha" runat="server"
            ControlToValidate="fechaFront" ForeColor="Red" ErrorMessage="*Debes tener al menos 18 años"
            Operator="LessThanEqual" Type="Date" ValidationGroup="frPerfil"></asp:CompareValidator>
        <br />
        <br />
        <div class="form-label-group form-group">
            <input type="Number" id="telefonoFront" runat="server" class="input-group-lg"
                autofocus="autofocus">
            <label for="cedula">Telefono</label>
            <asp:RequiredFieldValidator ID="rfvTelefono" runat="server" ControlToValidate="telefonoFront" ErrorMessage="*Numero de telefono requerido" ForeColor="Red" ValidationGroup="frPerfil"></asp:RequiredFieldValidator>

            <br />
        </div>
        <br />
        <div class="form-label-group form-group">
            <input type="text" id="DireccionFront" runat="server" class="input-group-lg" autofocus="autofocus">
            <label for="cedula">Direccion</label>
            <asp:RequiredFieldValidator ID="rfvDire" runat="server" ControlToValidate="DireccionFront" ErrorMessage="*Direccion requerida" ForeColor="Red" ValidationGroup="frPerfil"></asp:RequiredFieldValidator>

        </div>

        <br />

        <label>Nacionalidades</label>
        <br />
        <asp:DropDownList ID="lista1" Height="35px" Width="150px" runat="server" EnableViewState="true" Enabled="true" AppendDataBoundItems="true" CssClass="btn-outline-dark" />
        <asp:Button ID="addIdioma" runat="server" Text="Agregar mas Nacionalidades" CssClass="btn-outline-secondary" OnClick="addIdioma_Click" />
        <br />
        <br />
        <label>Genero</label>
        <br />
        <asp:DropDownList ID="lista2" CssClass="btn-outline-dark" Height="35px" Width="150px" runat="server" EnableViewState="true" Enabled="true" AppendDataBoundItems="true" />
        <asp:Button ID="AddGenero" runat="server" Text="Agregar mas Generos" CssClass="btn-outline-secondary" OnClick="AddGenero_Click" />

        <br />
        <br />



        <asp:Label ID="okVi" runat="server" Text="Perfil Agregado" CssClass="alert-danger" Visible="false"></asp:Label>

        <label id="Insertado" runat="server" visible="false" class="alert-success">El Usuario ha sido Creado con exito.</label>

        <hr />
        <h3 class="text-info">Informacion sobre estudios</h3>
        <hr />

        <label>Institucion en la que estudio </label>
        <br />
        <asp:DropDownList ID="lista3" Height="35px" CssClass="btn-outline-dark" runat="server" Width="150px" EnableViewState="true" Enabled="true" AppendDataBoundItems="true" />
        <asp:Button ID="addInstitucion" runat="server" Text="Agregar mas Instituciones" CssClass="btn-outline-secondary" Width="240px" OnClick="addInstitucion_Click" />
        <br />
        <br />
        <label>Carrera</label>
        <br />
        <asp:DropDownList ID="lista4" Height="35px" runat="server" CssClass="btn-outline-dark" Width="150px" EnableViewState="true" Enabled="true" AppendDataBoundItems="true" />
        <asp:Button ID="addCarrera" runat="server" CssClass="btn-outline-secondary" Text="Agregar mas Carreras" Width="240px" OnClick="addCarrera_Click" />
        <br />
        <br />
        <label>Grado de Estudio</label>
        <br />
        <asp:DropDownList ID="lista5" Height="35px" runat="server" CssClass="btn-outline-dark" Width="150px" EnableViewState="true" Enabled="true" AppendDataBoundItems="true" />
        <asp:Button ID="addGrado" runat="server" Text="Agregar mas Grados de estudio" CssClass="btn-outline-secondary" Width="240px" OnClick="addGrado_Click" />
        <br />
        <br />

        <hr />
        <h3 class="text-info">Informacion Laboral anterior</h3>
        <hr />
        <div class="form-label-group form-group">
            <input type="text" id="txtProfesion" runat="server" class="input-group-lg" autofocus="autofocus">
            <label for="txtProfesion">Profesion</label>
            <asp:RequiredFieldValidator ID="rfvProfesiin" runat="server" ControlToValidate="txtProfesion" ErrorMessage="*Profesion requerida" ForeColor="Red" ValidationGroup="frPerfil"></asp:RequiredFieldValidator>

        </div>
        <br />
        <div class="form-label-group form-group">
            <input type="number" id="txtExperiencia" runat="server" class="input-group-lg" autofocus="autofocus">
            <label for="txtExperiencia">Años de experiencia</label>
            <asp:RequiredFieldValidator ID="rfvExperencia" runat="server" ControlToValidate="txtExperiencia" ErrorMessage="*Años requeridos" ForeColor="Red" ValidationGroup="frPerfil"></asp:RequiredFieldValidator>

        </div>
        <br />
        <hr />
        <h3 class="text-info">Certificaciones</h3>
        <hr />

        <div class="form-label-group form-group">
            <input type="text" id="txtCertificacion" runat="server" class="input-group-lg" autofocus="autofocus">
            <label for="txtCertificacion">Certificación</label>
            <asp:RequiredFieldValidator ID="rfvCertificacion" runat="server" ControlToValidate="txtCertificacion" ErrorMessage="*Certificacion requerida" ForeColor="Red" ValidationGroup="frPerfil"></asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:TextBox TextMode="Date" Text='<%# Convert.ToDateTime(Eval("dateTime")).ToString("yyyy/MM/dd") %>' ID="fechaCerti" runat="server" Width="179px" />
            <asp:RequiredFieldValidator ID="rfvFechaCert" runat="server" ControlToValidate="fechaCerti" ErrorMessage="*Fecha requerida" ForeColor="Red" ValidationGroup="frPerfil"></asp:RequiredFieldValidator>

        </div>
        <br />
        <hr />
        <h3 class="text-info">Habilidades</h3>
        <hr />
        <br />
        <div class="form-label-group form-group">
            <input type="text" id="txtHabilidades" runat="server" class="input-group-lg" autofocus="autofocus">
            <label for="txtHabilidades">Habilidad</label>
            <asp:RequiredFieldValidator ID="frvHabilidad" runat="server" ControlToValidate="txtHabilidades" ErrorMessage="*Habilidad requerida" ForeColor="Red" ValidationGroup="frPerfil"></asp:RequiredFieldValidator>

        </div>
        <br />
        <h3 class="text-info">Informacion Adicional</h3>
        <hr />

        <br />

        <label>Segundo Idioma</label>
        <br />
        <asp:DropDownList ID="ListaIdiomas" Height="35px" Width="150px" CssClass="btn-outline-dark  " runat="server" EnableViewState="true" Enabled="true" AppendDataBoundItems="true" />
        <asp:Button ID="Button1" runat="server" Text="Agregar mas Idiomas" CssClass="btn-outline-secondary" OnClick="addIdioma2_Click" />
        <br />
        <br />
        <div class="form-label-group form-group">
            <input type="text" id="TxtIdioma" runat="server" class="input-group-sm" autofocus="autofocus">
            <label for="cedula">Nivel del Segundo Idioma</label>
            <asp:RequiredFieldValidator ID="rfvIdioma" runat="server" ControlToValidate="TxtIdioma" ErrorMessage="*Idioma requerido o digitar N/A" ForeColor="Red" ValidationGroup="frPerfil"></asp:RequiredFieldValidator>

        </div>
        <br />
        <label>Licencia</label>
        <br />
        <asp:DropDownList ID="ListaLicencias" Height="35px" Width="150px" CssClass="btn-outline-dark" runat="server" EnableViewState="true" Enabled="true" AppendDataBoundItems="true" />
        <asp:Button ID="Button2" runat="server" CssClass="btn-outline-secondary" Text="Agregar otra Licencia" OnClick="addLicencia_Click" />

        <br />
        <br />

        <hr />
        <asp:Button ID="AgregarPerfil" runat="server" Text="Modificar mi perfil" CssClass="btn-primary btn-lg " OnClick="AgregarPerfil_Click" ValidationGroup="frPerfil" />
        <br />

    </form>


</asp:Content>
