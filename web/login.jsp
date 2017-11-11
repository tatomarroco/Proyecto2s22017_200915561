<%-- 
    Document   : login
    Created on : 12/10/2017, 03:12:08 PM
    Author     : Estuardo
--%>

<%@page import="Controles.login" %>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>

<% 
        
    String mensaje="";
    if(session.getAttribute("sesionError")!=null){
        mensaje=String.valueOf(session.getAttribute("sesionError"));
    }
%>


<html lang="en">
<head>
  <title>Login</title>
  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <link rel="stylesheet" href="css/bootstrap.min.css">
  <link rel="stylesheet" href="css/Google-Style-Login.css">
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
            <li class="active"><a>&nbsp;&nbsp;&nbsp;Login</a></li>
      </ul>
    </div>
    
  </div>
</nav>

   
    
        <div class="login-card"><img src="img/avatar_2x.png" class="profile-img-card">
        <p class="profile-name-card"> </p>
        <form class="form-signin" action="login" method="post"><span class="reauth-email"> </span>
            <input class="form-control" type="text" required="" placeholder="Usuario" autofocus="" id="user" name="user">
            <input class="form-control" type="password" required="" placeholder="Contraseña" id="password" name="password">
            <div class="checkbox">
                <font color="red"><%=mensaje%></font>
            <%
                mensaje="";
                session.setAttribute("sesionError","");
            %>
                
                <!--<div class="checkbox">
                    <label>
                        <input type="checkbox">Remember me</label>
                </div>-->
            </div>
            <button class="btn btn-primary btn-block btn-lg btn-signin" type="submit" >LOGIN</button>
            
        </form><!--<a href="#" class="forgot-password">Forgot your password?</a>-->
            <div class="text-center">
                <a class="d-block small mt-3" href="registrar.jsp">Registrar una Cuenta</a>
            </div>
        </div>
    
    

  
    

          

</body>


</html>