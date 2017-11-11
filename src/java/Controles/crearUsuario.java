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
@WebServlet(urlPatterns = {"/crearUsuario"})
public class crearUsuario extends HttpServlet{
    public static OkHttpClient webClient = new OkHttpClient();
    String r="";
    
    public static String error="";

    public static String getError() {
        return error;
    }

    public static void setError(String error) {
        crearUsuario.error = error;
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
        String usuario = request.getParameter("user"); 
        String pass = request.getParameter("password");
        String cpass = request.getParameter("cpassword");
        String edad = request.getParameter("age");
        String direccion = request.getParameter("address");
        String tel = request.getParameter("telephone");
        if(cpass.length()>=4){
            /*Este codigo ve si los dos campos de contraseña que envia la pagina coinciden, si lo hacen envia user y password a Flask para crear usuario*/
            if(pass.equalsIgnoreCase(cpass)){
                RequestBody formBody = new FormEncodingBuilder()
                    .add("user",usuario)
                    .add("password", pass)
                    .add("age", edad)
                    .add("address", direccion)
                    .add("telephone", tel)
                    .build();
                r = getString("createuser", formBody);

                if(r.equalsIgnoreCase("true")){
                    response.sendRedirect("login.jsp");
                }
            }else{
                /*este es un setError da a la variable global "error" (importante que sea estatica e igual los metodos para set o get)*/
                setError("Contraseñas no coinciden");
                response.sendRedirect("registrar.jsp");  
            }
        }else{
            setError("La Contraseña debe tener al menos 4 caracteres.");
            response.sendRedirect("registrar.jsp");
        }    
                 
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
