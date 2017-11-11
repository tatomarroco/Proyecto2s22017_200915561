<%-- 
    Document   : pago
    Created on : 30/10/2017, 10:36:11 PM
    Author     : Estuardo
--%>
<%@page import="Controles.calculoTotal" %>
<%@page import="Controles.valores" %>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<%
    
    
    String usuario="";
    if(session.getAttribute("sesionusuario")==null){
        response.sendRedirect("index.jsp");
    }else{
        usuario = String.valueOf(session.getAttribute("sesionusuario"));
    }
    
    String vals = "";//htns.getServletInfo();
    String detext = "";
    String costohab="";
    String subext="";
    String total="";
    String dia,mes,anho;
    String nivel,habi,extras;
%>


<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>Lobby Hotel El Lobo</title>
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
            <div class="navbar-text"><font color="white" size="3">&nbsp;&nbsp&nbsp;&nbsp HOTEL El Lobo - Detalles/Pago</font></div>
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
    <form action="pagar" method="POST">

        <div class="col-lg-4">
            <%
                        vals = valores.getInfo();
                        nivel = valores.getNivel();
                        habi = valores.getHab();
            %>  
            <%=vals%>
            <input type="hidden" id="nivel" name="nivel" value="<%=nivel%>">
            <input type="hidden" id="habi" name="habi" value="<%=habi%>">
        </div>
        <div class="col-lg-4">
            <!--++++++++++++++++++++++Detalle de Reservacion+++++++++++++++++++++++-->
            <p class="btn-danger text-success">Detalle De Reservacion</p>
            <div class="form-group">
                <%
                        detext = calculoTotal.getInfoextras();
                        extras = String.valueOf(calculoTotal.getContadorExtras());
                %>  
                <%=detext%>
                <input type="hidden" id="extras" name="extras" value="<%=extras%>">
                <br>
                <p class="btn-link text-success">
                    Usted hizo solicitud de reserva para Fecha: 
                    <%  
                        dia = calculoTotal.getDia();   
                        mes = calculoTotal.getMes();
                        anho = calculoTotal.getAnho();
                    %>
                    <%=dia+"-"+mes+"-"+anho%>
                    <input type="hidden" id="dia" name="dia" value="<%=dia%>">
                    <input type="hidden" id="mes" name="mes" value="<%=mes%>">
                    <input type="hidden" id="anho" name="anho" value="<%=anho%>">
                </p>
                <p class="btn-warning text-success">
                    Costo Habitacion: Q. <%  costohab = String.valueOf(valores.getTotal());   %><%=costohab%>.00<br>
                    Extras: Q. <%  subext = String.valueOf(calculoTotal.getSubt());   %><%=subext%>.00
                </p>
                <p class="bg-success text-success">
                    Total a Pagar: Q. <%  total = String.valueOf(calculoTotal.getTotal());   %><%=total%>.00
                    <input type="hidden" id="total" name="total" value="<%=total%>">
                </p>
            </div>


            <!--+++++++++++++++++++++++++Informacion Tarjeta++++++++++++++++++++++++++++++++++-->
            <br>
            <p class="bg-primary text-success">Introduzca Numero de Tarjeta</p>
                <div class="input-group tel">
                    <input class="form-control" type="tel" name="tarjeta" id="tarjeta" placeholder="XXXXX" pattern="[1-9]{1}[0-9]{4}" required>
                    <span class="input-group-addon">
                            <span class="glyphicon glyphicon-credit-card" ></span>
                    </span>
                </div>
            <br>
            <input type="submit" class="btn-success" value="Realizar Pago y Reservar">
            
        </div>
                
    </form>
               
    <form action="lobby.jsp" method="POST">
        <input type="submit" class="btn-danger" value="Cancelar Reservacion y Regresar al Lobby">
    </form>
</div>
    
    </body>
</html>
