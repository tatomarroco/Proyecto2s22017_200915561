<%-- 
    Document   : cs
    Created on : 13/10/2017, 06:45:01 PM
    Author     : Estuardo
--%>
<%@page import="Controles.habitaciones" %>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<% 
session.setAttribute("sesionusuario", null);
session.invalidate();
response.sendRedirect("index.jsp");
habitaciones.setR("");
%>
