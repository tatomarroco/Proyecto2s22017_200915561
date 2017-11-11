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
@WebServlet(urlPatterns = {"/valores"})
public class valores extends HttpServlet{
    public static String hab="",nivel="";

    public static int valorhabitacion=0;

    public static int getTotal() {
        return valorhabitacion;
    }

    public static void setTotal(int total) {
        valores.valorhabitacion = total;
    }
    
    public static String getHab() {
        return hab;
    }

    public static void setHab(String hab) {
        valores.hab = hab;
    }

    public static String getNivel() {
        return nivel;
    }

    public static void setNivel(String nivel) {
        valores.nivel = nivel;
    }

    public static String getInfo() {
        return info;
    }

    public static void setInfo(String info) {
        valores.info = info;
    }
    public static String info="";
    
    
    
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
        String habi = request.getParameter("infohab");
        String piso = request.getParameter("infonivel");
        HttpSession sesion = request.getSession();
        String usuario = String.valueOf(sesion.getAttribute("sesionusuario"));
        valores.setHab(habi);
        valores.setNivel(piso);
        valorhabitacion = (Integer.parseInt(piso)*200)+ Integer.parseInt(habi);
        info = "<button type=\"button\" class=\"btn btn-block\" style=\"box-shadow: 1px 2px 5px #000000\" name=\"btnimg\" value=\"\"> \n "+
                    "<p class=\"bg-primary text-success\">Habitacion "+habi +"</br>Piso "+piso+"</p>"+
                    "<input type=\"hidden\" name=\"infohab\" value=\""+habi+"\">"+
                    "<input type=\"hidden\" name=\"infonivel\" value=\""+piso+"\">"+
                    "<img src=\"img/habita.png\" class=\"img-responsive\" style=\"width:100%\" alt=\"Image\"> \n"+
                    "<p class=\"bg-primary text-success\">Costo de Habitacion: Q. "+valorhabitacion+".00</p>\n"+
                    "</button>";
        
        response.sendRedirect("reservacion.jsp");
        
    }
    
     
    

    /**
     * Returns a short description of the servlet.
     *
     * @return a String containing servlet description
     */
    @Override
    public String getServletInfo() {
        return info;
    }// </editor-fold>
    
    
}
