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

@WebServlet(urlPatterns = {"/pagar"})
public class pagar extends HttpServlet{
    public static OkHttpClient webClient = new OkHttpClient();
    
    public static String error ="";
    
    public static String r ="";

    public static String getError() {
        return error;
    }

    public static void setError(String error) {
        pagar.error = error;
    }

    public void Reservacion(String anho, String mes, String dia, String codigo,String extras,String usuario,String tarjeta,String total){
        RequestBody formBody = new FormEncodingBuilder()
                .add("anho",anho)
                .add("mes",mes)
                .add("dia",dia)
                .add("codigohab",codigo)
                .add("extras",extras)
                .add("user",usuario)
                .add("tarjeta", tarjeta)
                .add("total", total)
                .build();
        r = getString("reservacion", formBody);  
    }
    
    public String getString(String metodo, RequestBody formBody) {
        try {
            URL url = new URL("http://tatomarroco.pythonanywhere.com/" + metodo);
            Request req = new Request.Builder().url(url).post(formBody).build();
            Response resp = webClient.newCall(req).execute();//Aqui obtiene la respuesta en dado caso si hayas pues un return en python
            String response_string = resp.body().string();//y este seria el string de las respuesta
            return response_string;
        } catch (MalformedURLException ex) {
            //java.util.logging.Logger.getLogger(proyecto2.TestWebServer.class.getName()).log(Level.SEVERE, null, ex);
            System.out.println(ex.getMessage());
        } catch (Exception ex) {
            //java.util.logging.Logger.getLogger(proyecto2.TestWebServer.class.getName()).log(Level.SEVERE, null, ex);
        System.out.println(ex.getMessage());
        }
        return null;
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
         String piso = request.getParameter("nivel");
         String habitacion = request.getParameter("habi");
         String codigo = piso+habitacion;
         String extras = request.getParameter("extras");
         String dia = request.getParameter("dia");
         String mes = request.getParameter("mes");
         String anho = request.getParameter("anho");
         String total = request.getParameter("total");
         String numtarjeta = request.getParameter("tarjeta");
         HttpSession sesion = request.getSession();
         String usuario = String.valueOf(sesion.getAttribute("sesionusuario"));
         Reservacion(anho, mes, dia, codigo, extras, usuario,numtarjeta,total);
         response.sendRedirect("lobby.jsp");
         
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
