﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrRecuperarContra.aspx.cs" Inherits="ProyectoAnalisis.FrRecuperarContra" %>

<!DOCTYPE html>
<html lang="en">

<head>

    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <meta name="description" content="">
    <meta name="author" content="">

    <title>SIRESEP RECUPERACION DE CONTRASEÑA</title>

    <!-- Bootstrap core CSS-->
    <link href="vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet">

    <!-- Custom fonts for this template-->
    <link href="vendor/fontawesome-free/css/all.min.css" rel="stylesheet" type="text/css">

    <!-- Custom styles for this template-->
    <link href="css/sb-admin.css" rel="stylesheet">
</head>
<body class="bg-dark">

    <div class="container">
        <div class="card card-register mx-auto mt-5">
            <div class="card-header">Recuperacion de contraseña</div>
            <h5 style="text-align: center">Digite la cedula del usuario</h5>
            <div class="card-body">
                <form runat="server">
                    <div class="form-group">
                        <div class="form-row">
                            <div class="col-md-6">
                                <div class="form-label-group">
                                    <%-- se puede usar esta para admitir cedulas nacioanales ^[0-9]{3}$   
                          se puede usar esta para admitir solo valores numericos sin importar la cantida de numeros   ^\d+$  --%>
                                    <input type="text" runat="server" id="cedula" class="form-control" required="required" autofocus="autofocus">
                                    <label for="cedula">Cedula</label>
                                    <asp:RegularExpressionValidator ID="revCedula" ControlToValidate="cedula" runat="server" ErrorMessage="*Solo digitos sin espacios." ForeColor="Red" ValidationExpression="^\d+$" ValidationGroup="frRegistro"></asp:RegularExpressionValidator>
                                </div>
                               
                            </div>
                             <p>**Se enviara la nueva contrasenia al correo electronico asociado a la cedula** </p>
                        </div>
                    </div>

<%--                    <div class="form-group">
                        <div class="form-label-group">
                            <input type="email" runat="server" id="inputEmail" class="form-control" placeholder="Email address" required="required" title="ejemplo@correo.com" pattern="[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,}$">
                            <label for="inputEmail">Correo Electronico</label>
                        </div>
                    </div>--%>

                    <asp:Button ID="btnRecuperar" href="#" runat="server" Text="Recuperar" CssClass="btn btn-primary btn-block" ValidationGroup="frRegistro" OnClick="btnRecuperar_Click" />
                    <br />


                    <%-- <div style="margin-left: auto; margin-right: auto; text-align: center;">
      <asp:Label runat="server" ID="labelFalse" CssClass="text-danger text-center" Visible="false">Ya existe un usuario asociado a esa Cedula o Correo</asp:Label>
    </div>--%>
                    <div style="margin-left: auto; margin-right: auto; text-align: center;">
                        <asp:Label runat="server" ID="label1" CssClass="text-danger text-center" Visible="false">El usuario no existe</asp:Label>
                    </div>
                </form>
                <div class="text-center">
                    <a class="d-block small mt-3" href="FrLogin.aspx">Pagina del Login</a>

                </div>
            </div>
        </div>
    </div>

    <!-- Bootstrap core JavaScript-->
    <script src="vendor/jquery/jquery.min.js"></script>
    <script src="vendor/bootstrap/js/bootstrap.bundle.min.js"></script>

    <!-- Core plugin JavaScript-->
    <script src="vendor/jquery-easing/jquery.easing.min.js"></script>

</body>

</html>
