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
@WebServlet(urlPatterns = {"/mireserva"})
public class mireserva extends HttpServlet{
    public static OkHttpClient webClient = new OkHttpClient();
    static String r="";
    public static String hab="",nivel="";
    public static String info="";
    
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
    
    public void Reservadas(String parametro){
        String cadena2="";
        RequestBody formBody = new FormEncodingBuilder()
                .add("user",parametro)
                .build();
        r = getString("hocupuser", formBody);
        
        
        
        String cadena1[] = r.split(",");
        for(int x=0;x<=cadena1.length-1;x++){
            cadena2 = cadena1[x];
            if(cadena2.equalsIgnoreCase("")){
                 info = "No tienes habitaciones para devolver";
            }else{
                hab = cadena2.substring(1, 3);
                nivel = cadena2.substring(0, 1);
                info += "<div class=\"col-sm-3\">\n"+ 
                    "<form action=\"devolver\" method=\"post\"> \n"+
                    "<button type=\"button\" class=\"btn btn-block\" style=\"box-shadow: 1px 2px 5px #000000\" name=\"btnhab\" value=\"submit\"> \n "+
                    "<p class=\"bg-primary text-success\">Habitacion "+hab +"</br>Piso "+nivel+"</p>"+
                    "<input type=\"hidden\" name=\"infohab\" value=\""+cadena2+"\">"+
                    "<img src=\"img/habita.png\" class=\"img-responsive\" style=\"width:100%\" alt=\"Image\"> \n"+
                    "</button> \n"+
                        "<div class='input-group date'>\n" +
                            "<input type=\"date\" class=\"form-control\"  name=\"fechadev\"/>\n" +
                            "<span class=\"input-group-addon\">\n" +
                                "<span class=\"glyphicon glyphicon-calendar\" id='datetimepicker1'></span>\n" +
                            "</span>\n "+
                        "</div>" +
                    "<input type=\"submit\" name=\"devolver\" value=\"Devolver Habitacion\" >"+
                    "</form> \n"+
                    "</div>";
            }
             
        }
    }
    
    
    public static String getR(){  
        return mireserva.info;
    }
    
    public static void setR(String inf){
        mireserva.info = inf;
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
        String habi = request.getParameter("gethab"); 
        HttpSession sesion = request.getSession();
        String usuario = String.valueOf(sesion.getAttribute("sesionusuario"));
        Reservadas(usuario);
        response.sendRedirect("misreservas.jsp");
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
