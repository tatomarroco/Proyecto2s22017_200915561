<%-- 
    Document   : misreservas
    Created on : 12/11/2017, 11:28:17 AM
    Author     : Estuardo
--%>

<%@page import="Controles.mireserva" %>
<%@page import="Controles.devolver" %>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<%
    mireserva htns = new mireserva();
    
    String usuario="";
    if(session.getAttribute("sesionusuario")==null){
        response.sendRedirect("index.jsp");
    }else{
        usuario = String.valueOf(session.getAttribute("sesionusuario"));
    }
    
    String habs = "";//htns.getServletInfo();
%>


<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>Hotel El Lobo</title>
        <meta charset="utf-8">
        <meta name="viewport" content="width=device-width, initial-scale=1">
        <!--<link rel="stylesheet" href="css/d.css">-->
        <link rel="stylesheet" href="css/bootstrap.min.css">
        <script src="js/jquery.min.js"></script>
        <script src="js/bootstrap.min.js"></script>
        
        <style>
            /* Remove the navbar's default margin-bottom and rounded borders */ 
            .navbar {
              margin-bottom: 0;
              border-radius: 0;
            }
    
            .dialogoejemplo{text-align:right;border:1px solid #888;-moz-border-radius:6px;-webkit-border-radius:6px;-khtml-border-radius:6px;border-radius:6px;-moz-box-shadow:1px 1px 20px rgba(0,0,0,0.4);-webkit-box-shadow:1px 1px 20px rgba(0,0,0,0.4);box-shadow:0 0 20px rgba(0,0,0,0.4)}

            /* Add a gray background color and some padding to the footer */
            footer {
              background-color: #f2f2f2;
              padding: 25px;
            }
        </style>
        
    <!--<script>
        window.onload=function(){
            // Una vez cargada la página, el formulario se enviara automáticamente.
            document.forms["peticion"].submit();
        }
    </script>-->
        
    </head>
    <body>
<!--++++++++++++++++++++++++++++++++++++++++++++++++BARRA NAV+++++++++++++++++++++++++++++++++++++++++++++++++++--> 
    <nav class="navbar navbar-inverse">
        <div class="container-fluid">
          <div class="navbar-header">
            <button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#myNavbar">
              <span class="icon-bar"></span>
              <span class="icon-bar"></span>
            </button>
            <div class="navbar-text"><font color="white" size="3">&nbsp;&nbsp&nbsp;&nbsp HOTEL El Lobo - Habitaciones Ocupadas</font></div>
          </div>
          <div class="collapse navbar-collapse" id="myNavbar">
            

              <!--Barra Buscador-->
        <!--    <form class="navbar-form navbar-nav" role="search" style="float: top">
                  &nbsp;&nbsp&nbsp;&nbsp&nbsp;&nbsp&nbsp;&nbsp&nbsp;&nbsp&nbsp;&nbsp&nbsp;&nbsp&nbsp;&nbsp&nbsp;&nbsp&nbsp;&nbsp&nbsp;&nbsp&nbsp;&nbsp&nbsp;&nbsp&nbsp;&nbsp&nbsp;&nbsp&nbsp;&nbsp
                  <div class="input-group" > 
                      <input type="text" class="form-control" style="width: 450px" placeholder="Buscar en el Drive">
                      <span class="input-group-btn">
                          <button class="btn btn-default" type="button">
                              <span class="glyphicon glyphicon-search"></span>
                          </button>
                      </span>
                  </div>
                </form>     -->
              <!--++++++++++++++++-->


            <!--ELEMENTOS DE SESION-->   
            <ul class="nav navbar-nav navbar-right">
                <li>
                    <div class="navbar-text">
                        <span style="color:chartreuse" class="glyphicon glyphicon-user"></span>
                        <font color="white" size="3"> <%=usuario%>'s Cliente</font>
                    </div>
                </li>  
              <li>
                  <a href="cs.jsp"><span class="glyphicon glyphicon-log-out"></span> Cerrar Sesión</a>
              </li>
            </ul>
            <!--++++++++++++++++++++++++++++++++++++++++++-->  

          </div>
        </div>
    </nav>
<!--++++++++++++++++++++++++++++++++++++++++FIN BARRA NAV+++++++++++++++++++++++++++++++++++++++++++++++++-->

<!--++++++++++++++++++++++++++++++++++++++++CONTENIDO PRINCIPAL+++++++++++++++++++++++++++++++++++++++++++++++++-->

<footer class="container-fluid" style="-webkit-box-shadow: inset 0px 6px 7px -1px rgba(0,0,0,0.34);
-moz-box-shadow: inset 0px 6px 7px -1px rgba(0,0,0,0.34);
box-shadow: inset 0px 6px 7px -1px rgba(0,0,0,0.34);">
               
        
                <div class="btn-group col-sm-3">
                    <form name="peticion" action="mireserva" method="POST">
                        <input type="hidden" name="gethab" value="nada">
                        <input style="-webkit-box-shadow: 4px 5px 7px -1px rgba(0,0,0,0.34);
                            -moz-box-shadow: 4px 5px 7px -1px rgba(0,0,0,0.34);
                            box-shadow: 4px 5px 7px -1px rgba(0,0,0,0.34);" class="btn btn-primary btn-sm" type="submit" name="mostrar" value="Habitaciones Disponibles"/>
                    </form>
                </div>
                <!--DIRECCION++++++++++++++++++++++++++-->  
                <!--<div class="col-sm-9">
                    <p class="text-left text-warning"><span class="glyphicon glyphicon-triangle-right"></span>/</p>
                </div>-->
                <!--+++++++++++++++++++++++++++++++++++-->   
</footer>

<br>
<div class="row col-lg-8 col-md-offset-2 text-center" style="overflow: auto; height:480px">
    <%
                    habs = mireserva.getR();
    %>  
    <%=habs%>
    <%
                    mireserva.setR("");
    %>
</div>
    
    </body>
</html>