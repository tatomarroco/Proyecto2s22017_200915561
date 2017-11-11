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
@WebServlet(urlPatterns = {"/login"})
public class login extends HttpServlet{
    public static OkHttpClient webClient = new OkHttpClient();
    String r="";
    
    
    protected void processRequest(HttpServletRequest request, HttpServletResponse response)throws ServletException, IOException {
        response.setContentType("text/html;charset=UTF-8");
        try (PrintWriter out = response.getWriter()) {           
            if(request.getSession().getAttribute("sesionusuario")==null){
                response.sendRedirect("index.jsp");
            } 
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
    @Override
    protected void doGet(HttpServletRequest request, HttpServletResponse response)throws ServletException, IOException {
        //processRequest(request, response);
        /*peticiones GET hechas desde la pagina*/
    }

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
       /*peticiones POST hechas desde la pagina*/
        String usuario = request.getParameter("user"); 
        String pass = request.getParameter("password");    
        RequestBody formBody = new FormEncodingBuilder()
                .add("user",usuario)
                .add("password", pass)
                .build();
        r = getString("login", formBody);
        
            if(r.equalsIgnoreCase("true")){
                           /*si todo coincide le da true a una variable de sesion que puede ser utilizada en la pagina*/
                           HttpSession sesion = request.getSession(true);
                           HttpSession sesion2 = request.getSession(true);
                           sesion.setAttribute("sesionusuario",usuario);
                           sesion2.setAttribute("sesionpass",pass);
                           response.sendRedirect("lobby.jsp");
                           //processRequest(request, response);
            }else{
                /*Esta parte sirve cuando el usuario mete mal uno de los parametros y si no coincide con lo almacenado en Python nos devuelve un SesionError*/
                HttpSession sesion2 = request.getSession(true);
                sesion2.setAttribute("sesionError","Usuario o Contraseña Inválidos");
                response.sendRedirect("login.jsp");
            }
    }
    
    /*Lineas de codigo para hacerle peticiones a Flask*/
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
    

    /**
     * Returns a short description of the servlet.
     *
     * @return a String containing servlet description
     */
    @Override
    public String getServletInfo() {
        return "Short description";
    }// </editor-fold>
    
}
