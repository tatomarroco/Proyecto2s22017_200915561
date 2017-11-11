<%-- 
    Document   : lobby
    Created on : 12/10/2017, 10:59:46 PM
    Author     : Estuardo
--%>

<%@page import="Controles.calculoTotal"%>
<%@page import="Controles.valores" %>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<%
    valores valors = new valores();
    
    String usuario="";
    if(session.getAttribute("sesionusuario")==null){
        response.sendRedirect("index.jsp");
    }else{
        usuario = String.valueOf(session.getAttribute("sesionusuario"));
    }
    
    String vals = "";//htns.getServletInfo();
    String Error ="";
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
            <div class="navbar-text"><font color="white" size="3">&nbsp;&nbsp&nbsp;&nbsp HOTEL El Lobo - Reservacion</font></div>
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
                    <form name="peticion" action="lobby.jsp" method="POST">
                        
                        <input style="-webkit-box-shadow: 4px 5px 7px -1px rgba(0,0,0,0.34);
                            -moz-box-shadow: 4px 5px 7px -1px rgba(0,0,0,0.34);
                            box-shadow: 4px 5px 7px -1px rgba(0,0,0,0.34);" class="btn btn-primary btn-sm" type="submit" value="Regresar Al Lobby"/>
                    </form>
                </div>
                <!--DIRECCION++++++++++++++++++++++++++-->  
                <!--<div class="col-sm-9">
                    <p class="text-left text-warning"><span class="glyphicon glyphicon-triangle-right"></span>/</p>
                </div>-->
                <!--+++++++++++++++++++++++++++++++++++-->   
</footer>

<br>
<div class="row col-lg-7 col-md-offset-3 text-center" style="overflow: auto; height:480px">
    <form action="calculo" method="POST">

        <div class="col-lg-4">
            <%
                        vals = valores.getInfo();
            %>  
            <%=vals%>
        </div>
        <div class="col-lg-4">
            <!--++++++++++++++++++++++Fecha de RESERVACION+++++++++++++++++++++++-->
            <p class="btn-danger text-success">FECHA DE RESERVACION</p>
            <div class="form-group">
                    <div class='input-group date'>
                        <input type="date" class="form-control"  name="fechareserva"/>
                        <span class="input-group-addon">
                            <span class="glyphicon glyphicon-calendar" id='datetimepicker1'></span>
                        </span>
                    </div>
            </div>


            <!--+++++++++++++++++++++++++EXTRAS++++++++++++++++++++++++++++++++++-->
            <br>
            <p class="btn-warning text-success">EXTRAS</p>
            <div class="checkbox">
                <label><input type="checkbox" name="ext1" >Servicion De Limpieza</label>
            </div>
            <div class="checkbox">
                <label><input type="checkbox" name="ext2" >TV Con Cable</label>
            </div>
            <div class="checkbox">
                <label><input type="checkbox" name="ext3" >Internet/Wifi</label>
            </div>
            <div class="checkbox">
                <label><input type="checkbox" name="ext4" >Netflix</label>
            </div>
            <div class="checkbox">
                <label><input type="checkbox" name="ext5" >Desayuno</label>
            </div>
            <br />
            <input type="submit" class="btn-success" value="Reservar">


        </div>
    </form>
        
        <%
            Error = calculoTotal.getError();
        %>
        <!--muestro el mensaje (o la variable)-->
        <p class="row col-lg-7 col-md-offset-3 text-center"><font color="red"><%=Error%></font></p>
        
        <%
                    Error="";
                    calculoTotal.setError("");
        %>
</div>
    
    </body>
</html>
