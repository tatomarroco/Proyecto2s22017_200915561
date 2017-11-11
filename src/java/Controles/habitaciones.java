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
@WebServlet(urlPatterns = {"/habitaciones"})
public class habitaciones extends HttpServlet{
    public static OkHttpClient webClient = new OkHttpClient();
    static String r="";
    public String hab="",nivel="";
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
    
    public void HabitacionesDisponibles(String parametro){
        RequestBody formBody = new FormEncodingBuilder()
                .add("gethab",parametro)
                .build();
        r = getString("obtenerHabitaciones", formBody);
        
        
        
        String cadena1[] = r.split(":");
        for(int x=0;x<=cadena1.length-1;x++){
            String cadena2[] = cadena1[x].split(",");
            hab = cadena2[0];
            nivel = cadena2[1];
            
            info += "<div class=\"col-sm-3\">\n"+ 
                    "<form action=\"valores\" method=\"post\"> \n"+
                    "<button type=\"submit\" class=\"btn btn-block\" style=\"box-shadow: 1px 2px 5px #000000\" name=\"btnhab\" value=\"submit\"> \n "+
                    "<p class=\"bg-primary text-success\">Habitacion "+hab +"</br>Piso "+nivel+"</p>"+
                    "<input type=\"hidden\" name=\"infohab\" value=\""+hab+"\">"+
                    "<input type=\"hidden\" name=\"infonivel\" value=\""+nivel+"\">"+
                    "<img src=\"img/habita.png\" class=\"img-responsive\" style=\"width:100%\" alt=\"Image\"> \n"+
                    "</button> \n"+
                    "</form> \n"+
                    "</div>";  
        }
    }
    
    
    public static String getR(){  
        return habitaciones.info;
    }
    
    public static void setR(String inf){
        habitaciones.info = inf;
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
        HabitacionesDisponibles(habi);
        response.sendRedirect("lobby.jsp");
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
