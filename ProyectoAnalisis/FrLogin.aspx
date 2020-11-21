<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrLogin.aspx.cs" Inherits="ProyectoAnalisis.Login" %>

<!DOCTYPE html>
<html lang="en">

  <head>

    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <meta name="description" content="">
    <meta name="author" content="">

    <title>SIRESEP - Login</title>
    <link href="vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet">
    <link href="vendor/fontawesome-free/css/all.min.css" rel="stylesheet" type="text/css">
    <link href="css/sb-admin.css" rel="stylesheet">

  </head>
    
  <body class="bg-dark">
      <form id="form1" runat="server">
   <div class="page-header bg-light text-center">
    <h1>SIRESEP</h1>      
  </div>
    <div class="container" runat="server">
      <div class="card card-login mx-auto mt-5">
        <div class="card-header">Login</div>
        <div class="card-body">
            <div class="form-group">
              <div class="form-label-group">
                <input type="text" id="cedula" runat="server" class="form-control" placeholder="cedula" required="required" autofocus="autofocus">
                <label for="cedula">Cedula</label>
                  <asp:RegularExpressionValidator ID="revCedula" ControlToValidate="cedula" runat="server" ErrorMessage="*Solo digitos sin espacios." ForeColor="Red"  ValidationExpression="^\d+$" ValidationGroup="frLogin"></asp:RegularExpressionValidator>

              </div>
            </div>
            <div class="form-group">
              <div class="form-label-group">
                <input type="password" runat="server" id="inputPassword" class="form-control" placeholder="Password" required="required">
                <label for="inputPassword">Password</label>
              </div>
            </div>
            <div class="form-group">

            </div>
          
             <asp:Button ID="Button1" href = "#" runat="server" Text="Login" CssClass="btn btn-primary btn-block" OnClick="Iniciar_Click" ValidationGroup="frLogin"  />

            <%--<asp:Button ID="Button2" href = "#" runat="server" Text="Recuperar Contraseña" CssClass="btn btn-primary btn-block"  ValidationGroup="frLogin" OnClick="RecuperarContra"  />--%>
          <div class="text-center">
            <a class="d-block small mt-3" runat="server" href="FrRegistro.aspx">Registrarse</a>
            <a class="d-block small mt-3" href="FrRecuperarContra.aspx">Recuperar Contraseña</a>

      
          </div>
        </div>
      </div>
        <div style="margin-left: auto; margin-right: auto; text-align: center;">
      <asp:Label runat="server" ID="label1" CssClass="text-danger text-center" Visible="false">Credenciales Incorrectas</asp:Label>
    </div>
    </div>

    <!-- Bootstrap core JavaScript-->
    <script src="vendor/jquery/jquery.min.js"></script>
    <script src="vendor/bootstrap/js/bootstrap.bundle.min.js"></script>

    <!-- Core plugin JavaScript-->
    <script src="vendor/jquery-easing/jquery.easing.min.js"></script>

      </form>

  </body>

</html>

