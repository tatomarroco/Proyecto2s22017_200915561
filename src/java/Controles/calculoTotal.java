/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Controles;

import com.squareup.okhttp.FormEncodingBuilder;
import com.squareup.okhttp.OkHttpClient;
import com.squareup.okhttp.Request;
import com.squareup.okhttp.RequestBody;
import com.squareup.okhttp.Response;
import java.io.IOException;
import java.io.PrintWriter;
import java.net.MalformedURLException;
import java.net.URL;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;

/**
 *
 * @author Estuardo
 */
@WebServlet(urlPatterns = {"/calculo"})
public class calculoTotal extends HttpServlet{
    
    public static String error ="";

    public static int contadorExtras = 0;

    public static int getContadorExtras() {
        return contadorExtras;
    }

    public static void setContadorExtras(int contadorExtras) {
        calculoTotal.contadorExtras = contadorExtras;
    }
    
    
    public static String getError() {
        return error;
    }

    public static void setError(String error) {
        calculoTotal.error = error;
    }
    
    public static String infoextras="";
    
    public static int subt=0;

    public static int getSubt() {
        return subt;
    }

    public static void setSubt(int subt) {
        calculoTotal.subt = subt;
    }

    public static String getInfoextras() {
        return infoextras;
    }

    public static void setInfoextras(String infoextras) {
        calculoTotal.infoextras = infoextras;
    }

    public static String getDia() {
        return dia;
    }

    public static void setDia(String dia) {
        calculoTotal.dia = dia;
    }

    public static String getMes() {
        return mes;
    }

    public static void setMes(String mes) {
        calculoTotal.mes = mes;
    }

    public static String getAnho() {
        return anho;
    }

    public static void setAnho(String anho) {
        calculoTotal.anho = anho;
    }
    
    public static String dia, mes, anho;
    
    public static int total=0;

    public static int getTotal() {
        return total;
    }

    public static void setTotal(int total) {
        calculoTotal.total = total;
    }
    
    
    
    
    public int calcular(String xt1, String xt2, String xt3, String xt4, String xt5){
        int contador = 0;
        int subtotalxt = 0; 
        if(xt1!=null){
            contador +=1;
            infoextras += "<span style=\"color:chartreuse\" class=\"glyphicon glyphicon-ok-sign\"></span> Servicio De Limpieza<br>";
        }else{
            infoextras += "<span style=\"color:#ff0000\" class=\"glyphicon glyphicon-remove-sign\"></span> Servicio De Limpieza<br>";
        }
        if(xt2!=null){
            contador +=1;
            infoextras += "<span style=\"color:chartreuse\" class=\"glyphicon glyphicon-ok-sign\"></span> TV Con Cable<br>";
        }else{
            infoextras += "<span style=\"color:#ff0000\" class=\"glyphicon glyphicon-remove-sign\"></span> TV Con Cable<br>";
        }
        if(xt3!=null){
            contador +=1;
            infoextras += "<span style=\"color:chartreuse\" class=\"glyphicon glyphicon-ok-sign\"></span> Internet/Wifi<br>";
        }else{
            infoextras += "<span style=\"color:#ff0000\" class=\"glyphicon glyphicon-remove-sign\"></span> Internet/Wifi<br>";
        }
        if(xt4!=null){
            contador +=1;
            infoextras += "<span style=\"color:chartreuse\" class=\"glyphicon glyphicon-ok-sign\"></span> Netflix<br>";
        }else{
            infoextras += "<span style=\"color:#ff0000\" class=\"glyphicon glyphicon-remove-sign\"></span> Netflix<br>";
        }
        if(xt5!=null){
            contador +=1;
            infoextras += "<span style=\"color:chartreuse\" class=\"glyphicon glyphicon-ok-sign\"></span> Desayuno<br>";
        }else{
            infoextras += "<span style=\"color:#ff0000\" class=\"glyphicon glyphicon-remove-sign\"></span> Desayuno<br>";
        }
        
        if(contador >3){
            subtotalxt = (contador*50);
            setSubt(subtotalxt);
            setContadorExtras(contador);
            return subtotalxt;
        }else{
            subtotalxt = (contador*75);
            setSubt(subtotalxt);
            setContadorExtras(contador);
            return subtotalxt;
        }
        
        
        
    }
    
    
    // <editor-fold defaultstate="collapsed" desc="HttpServlet methods. Click on the + sign on the left to edit the code.">
    /**
     * Handles the HTTP <code>GET</code> method.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    
    /**
     * Handles the HTTP <code>POST</code> method.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    @Override
    protected void doPost(HttpServletRequest request, HttpServletResponse response)throws ServletException, IOException {
        setInfoextras("");
        setAnho("");
        setDia("");
        setMes("");
        setSubt(0);
        setTotal(0);
        setError("");
        String fechareserva = request.getParameter("fechareserva");
        if(fechareserva.equalsIgnoreCase("")){
            setError("Error: Olvidó seleccionar la Fecha de Reservacion");
            response.sendRedirect("reservacion.jsp");
        }else{
            String extra1 = request.getParameter("ext1");
            String extra2 = request.getParameter("ext2");
            String extra3 = request.getParameter("ext3");
            String extra4 = request.getParameter("ext4");
            String extra5 = request.getParameter("ext5");
            String fecha[] = fechareserva.split("-");
            setAnho(fecha[0]);
            setMes(fecha[1]);
            setDia(fecha[2]);
            int costohab = valores.getTotal();
            HttpSession sesion = request.getSession();
            String usuario = String.valueOf(sesion.getAttribute("sesionusuario"));
            int subtotal = calcular(extra1, extra2, extra3, extra4, extra5);
            total = costohab + subtotal;
            response.sendRedirect("pago.jsp");
        }
        
        
        
    }
    
     
    

    /**
     * Returns a short description of the servlet.
     *
     * @return a String containing servlet description
     */
    @Override
    public String getServletInfo() {
        return "";
    }// </editor-fold>
}
