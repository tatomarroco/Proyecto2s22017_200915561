using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Collections.Specialized;
using System.Runtime.InteropServices;
using System.Security;
using System.Collections;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Threading;

namespace Proyecto2s22017CSharp{
    class conexion{



        public String Graficas(string opcion){
            String usuarios="";

            using (var cliente = new WebClient()){
                var variablesEnviar = new NameValueCollection();
                variablesEnviar["grafica"] = opcion;

                var serverRequest = cliente.UploadValues("http://tatomarroco.pythonanywhere.com/graficar", variablesEnviar);
                usuarios = Encoding.Default.GetString(serverRequest);
                Console.WriteLine(usuarios);
            }
            return usuarios;
        }

        public void crearImagen(string nombreArchivo){
            try{
                using (System.IO.StreamWriter escritor = new System.IO.StreamWriter(@"C:\\Users\\Estuardo\\Documents\\NetBeansProjects\\Proyecto2s22017\\graficas\\graficar.bat"))
                {
                    
                    escritor.WriteLine("@echo off");
                    escritor.WriteLine("DEL "+ "\""+"C:\\Users\\Estuardo\\Documents\\NetBeansProjects\\Proyecto2s22017\\graficas\\" + nombreArchivo + ".txt.jpg"+"\"");
                    escritor.WriteLine("\"" + "C:\\Program Files (x86)\\Graphviz2.38" + "\"" + "\\bin\\DOT -Tjpg  -O C:\\Users\\Estuardo\\Documents\\NetBeansProjects\\Proyecto2s22017\\graficas\\"+ nombreArchivo +".txt");
                }
                //Thread.Sleep(2000);
                System.Diagnostics.Process.Start("C:\\Users\\Estuardo\\Documents\\NetBeansProjects\\Proyecto2s22017\\graficas\\graficar.bat");
                //Thread.Sleep(2000);
                /*var pInfo = new System.Diagnostics.ProcessStartInfo("cmd", "/C dot -Tjpg C:\\Users\\Estuardo\\Documents\\NetBeansProjects\\Proyecto2s22017\\graficas\\"+ nombreArchivo +".txt -o C:\\Users\\Estuardo\\Documents\\NetBeansProjects\\Proyecto2s22017\\graficas\\"+nombreArchivo+".jpg");
                var proceso = new System.Diagnostics.Process();

                proceso.StartInfo = pInfo;

                proceso.Start();
                proceso.WaitForExit();
                proceso.Refresh();*/
                
            }
            catch (Exception x){
                Console.WriteLine(x.ToString());
            }
        }


    }
}
