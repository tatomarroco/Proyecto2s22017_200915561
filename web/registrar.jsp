<%-- 
    Document   : registrar
    Created on : 12/10/2017, 11:41:10 AM
    Author     : Estuardo
--%>

<%@page import="Controles.crearUsuario" %>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>

<% 
        
    String mensaje="";
    
%>

<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>Registrar</title>
        <meta charset="utf-8">
        <meta name="viewport" content="width=device-width, initial-scale=1">
        <link rel="stylesheet" href="css/bootstrap.min.css">
        <script src="js/jquery.min.js"></script>
        <script src="js/bootstrap.min.js"></script>
        <!-- Custom styles for this template -->
        <link href="css/sb-admin.css" rel="stylesheet">
    </head>
    <body>
        
        <nav class="navbar navbar-inverse">
  <div class="container-fluid">
    <div class="navbar-header">
        <ul class="nav navbar-nav">
            <li class="active"><a>&nbsp;&nbsp;&nbsp;Registrar</a></li>
      </ul>
    </div>
    
  </div>
</nav>
        
        
        
        <div class="row register-form">
        <div class="col-md-8 col-md-offset-2">
            <form class="form-horizontal custom-form" action="crearUsuario" method="post">
                <h1>Registrar</h1>
                <div class="form-group">
                    <div class="col-sm-4 label-column">
                        <label class="control-label" for="user-input-field">Usuario</label>
                    </div>
                    <div class="col-sm-6 input-column">
                        <input class="form-control" type="text" name="user" id="user" placeholder="Usuario"  required>
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-sm-4 label-column">
                        <label class="control-label" for="pawssword-input-field">Contraseña </label>
                    </div>
                    <div class="col-sm-6 input-column">
                        <input class="form-control" type="password" name="password" id="password" placeholder="Contraseña"  required>
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-sm-4 label-column">
                        <label class="control-label" for="repeat-pawssword-input-field">Confirmar Contraseña</label>
                    </div>
                    <div class="col-sm-6 input-column">
                        <input class="form-control" type="password" name="cpassword" id="cpassword" placeholder="Confirmar Contraseña"  required>
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-sm-4 label-column">
                        <label class="control-label" for="age-input-field">Edad</label>
                    </div>
                    <div class="col-sm-6 input-column">
                        <input class="form-control" type="number" min="18" max="100" name="age" id="age" placeholder="Edad"  required>
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-sm-4 label-column">
                        <label class="control-label" for="address-input-field">Direccion</label>
                    </div>
                    <div class="col-sm-6 input-column">
                        <input class="form-control" type="text" name="address" id="address" placeholder="Direccion"  required>
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-sm-4 label-column">
                        <label class="control-label" for="address-input-field">Telefono</label>
                    </div>
                    <div class="col-sm-6 input-column">
                        <input class="form-control" type="tel" name="telephone" id="telephone"  placeholder="Telefono"  required>
                    </div>
                </div>
                <input type="submit" class="btn btn-default btn-primary" value="Registrar" name="register" />
                <div class="form-group col-sm-6 input-column">
                <!--asigno a la variable mensaje creada arriba un error en dado caso lo haya -->
                <%
                    mensaje = crearUsuario.getError();
                %>
                <!--muestro el mensaje (o la variable)-->
                <font color="red"><%=mensaje%></font>
                
                <%
                    mensaje="";
                    crearUsuario.setError("");
                %>
                </div>
                
            </form>
        </div>
    </div>
        
    </body>
</html>