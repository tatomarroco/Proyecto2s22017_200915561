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

namespace Proyecto2s22017CSharp
{
    class cargarXML{
        XmlDocument xDoc = new XmlDocument(); //Creo un nuevo Documento XML
        string user, password, age, address, tel,piso,numhab,tarjeta,fechaOc, fechaDev="",dia,mes,anho,codigohab;
        int contadorExt = 0,subtotalExt=0, total=0;

        //El Open Dialog envia un atributo tipo Stream 
        public void analizarUsuarios(Stream archivo){
            if (archivo.CanRead){
                xDoc.Load(archivo); //Cargo el archivo que va a leer como XML

                XmlNodeList xApertura = xDoc.GetElementsByTagName("usuarios"); //El Tag de Apertura
                XmlNodeList xUsuario = ((XmlElement)xApertura[0]).GetElementsByTagName("usuario"); //etiqueta "usuario" 

                foreach (XmlElement nodo in xUsuario){ //En este Foreach va leyendo cada etiqueta dentro de cada etiqueta "usuario"
                    XmlNodeList xNombre = nodo.GetElementsByTagName("nombre");
                    XmlNodeList xPass = nodo.GetElementsByTagName("password");
                    XmlNodeList xEdad = nodo.GetElementsByTagName("edad");
                    XmlNodeList xDireccion = nodo.GetElementsByTagName("direccion");
                    XmlNodeList xTelefono = nodo.GetElementsByTagName("telefono");
                    foreach (XmlElement nodoNombre in xNombre){
                        user = nodoNombre.InnerText;//InnerText va recuperando el texto entre las etiquetas especificas
                    }
                    foreach (XmlElement nodoPass in xPass){
                        password = nodoPass.InnerText;
                    }
                    foreach (XmlElement nodoEdad in xEdad){
                        age = nodoEdad.InnerText;
                    }
                    foreach (XmlElement nodoDireccion in xDireccion){
                        address = nodoDireccion.InnerText;
                    }
                    foreach (XmlElement nodoTel in xTelefono){
                        tel = nodoTel.InnerText;
                    }

                    Console.Write("User: " + user + "\n Password: " + password + "\n Age: " + age + "\n Address: " + address + "\n Tel: " + tel +"\n \n");
                    CrearUsuario(user, password, age, address, tel);
                }
            }

        
        }


        public void analizarHabitaciones(Stream archivo){
            if (archivo.CanRead){
                xDoc.Load(archivo); //Cargo el archivo que va a leer como XML

                XmlNodeList xApertura = xDoc.GetElementsByTagName("habitaciones"); //El Tag de Apertura
                XmlNodeList xHabitacion = ((XmlElement)xApertura[0]).GetElementsByTagName("habitacion"); //etiqueta "habitacion" 

                foreach (XmlElement nodo in xHabitacion)
                { //En este Foreach va leyendo cada etiqueta dentro de cada etiqueta "habitacion"
                    XmlNodeList xPiso = nodo.GetElementsByTagName("nivel");
                    XmlNodeList xNum = nodo.GetElementsByTagName("numero");
                    foreach (XmlElement nodoNivel in xPiso)
                    {
                        piso = nodoNivel.InnerText;//InnerText va recuperando el texto entre las etiquetas especificas
                    }
                    foreach (XmlElement nodoNum in xNum)
                    {
                        numhab = nodoNum.InnerText;
                    }

                    Console.Write("Habitacion: " + numhab + "\n Piso: " + piso + "\n ID: " + piso + numhab+ "\n \n");
                    CrearHabitacion(numhab, piso);
                }
            }
        }

        public void analizarReservaciones(Stream archivo) {
            if (archivo.CanRead) {
                xDoc.Load(archivo); //Cargo el archivo que va a leer como XML

                XmlNodeList xApertura = xDoc.GetElementsByTagName("reservaciones");
                XmlNodeList xReservacion = ((XmlElement)xApertura[0]).GetElementsByTagName("reservacion");

                foreach (XmlElement nodo in xReservacion) {
                    XmlNodeList xUsuario = nodo.GetElementsByTagName("usuario");
                    XmlNodeList xTarjeta = nodo.GetElementsByTagName("tarjeta");
                    XmlNodeList xHabitacion = nodo.GetElementsByTagName("habitacion");
                    XmlNodeList xAperturaExtras = nodo.GetElementsByTagName("extras");
                    contadorExt = 0;
                    subtotalExt = 0;
                    total = 0;
                    if (xAperturaExtras.Count > 0){
                        XmlNodeList xExtra = ((XmlElement)xAperturaExtras[0]).GetElementsByTagName("extra");
                       
                        foreach (XmlElement nodoExtra in xExtra)
                        {
                            contadorExt += 1;
                        }
                    }
                    
                    if(contadorExt > 3){
                        subtotalExt = contadorExt * 50;
                    }else if(contadorExt <= 3){
                        subtotalExt = contadorExt * 75;
                    }
                    XmlNodeList xFechaIngreso = nodo.GetElementsByTagName("fechaIngreso");
                    XmlNodeList xFechaSalida = nodo.GetElementsByTagName("fechaSalida");
                    foreach (XmlElement nodoUsuario in xUsuario){
                        user = nodoUsuario.InnerText;//InnerText va recuperando el texto entre las etiquetas especificas
                    }
                    foreach (XmlElement nodoTarjeta in xTarjeta) {
                        tarjeta = nodoTarjeta.InnerText;
                    }
                    foreach (XmlElement nodoCodigoHab in xHabitacion) {
                        codigohab = nodoCodigoHab.InnerText;
                        if (codigohab.Length == 4){
                            piso = codigohab[0].ToString() + codigohab[1].ToString();
                            numhab = codigohab[2].ToString() + codigohab[3].ToString();
                        }
                        else if (codigohab.Length == 3) {
                            piso = codigohab[0].ToString();
                            numhab = codigohab[1].ToString() + codigohab[2].ToString();
                        }
                        total = ((int.Parse(piso) * 200) + int.Parse(numhab));
                    }
                    foreach (XmlElement nodoFechaIngreso in xFechaIngreso) {
                        fechaOc = nodoFechaIngreso.InnerText;
                        dia = fechaOc[0].ToString() + fechaOc[1].ToString();
                        mes = fechaOc[2].ToString() + fechaOc[3].ToString();
                        anho = fechaOc[4].ToString() + fechaOc[5].ToString() + fechaOc[6].ToString() + fechaOc[7].ToString(); 
                    }
                    foreach (XmlElement nodoFechaDev in xFechaSalida) {
                        fechaDev = nodoFechaDev.InnerText;
                    }

                    total += subtotalExt;

                    CrearReservacion(dia, mes, anho, fechaOc, user, contadorExt.ToString(), tarjeta, codigohab, total.ToString(), fechaDev);

                }

            }
        }

        public void CrearUsuario(String User, String Password, String Age, String Address, String Tel){
            System.Windows.Forms.DialogResult result;
            using (var cliente = new WebClient()){
                var variablesEnviar = new NameValueCollection();
                variablesEnviar["user"] = User;
                variablesEnviar["password"] = Password;
                variablesEnviar["age"] = Age;
                variablesEnviar["address"] = Address;
                variablesEnviar["telephone"] = Tel;

                var respuestaMetodo = cliente.UploadValues("http://tatomarroco.pythonanywhere.com/createuser", variablesEnviar);
                var respuestaConvertidaString = Encoding.Default.GetString(respuestaMetodo);
                result = MessageBox.Show("Usuario Insertado", "Sistema");
                Console.WriteLine(respuestaConvertidaString);
            }
        }


        public void CrearHabitacion(String Habitacion, String Nivel)
        {
            System.Windows.Forms.DialogResult result;
            using (var cliente = new WebClient())
            {
                var variablesEnviar = new NameValueCollection();
                variablesEnviar["numhab"] = Habitacion;
                variablesEnviar["nivel"] = Nivel;
                

                var respuestaMetodo = cliente.UploadValues("http://tatomarroco.pythonanywhere.com/createroom", variablesEnviar);
                var respuestaConvertidaString = Encoding.Default.GetString(respuestaMetodo);
                result = MessageBox.Show("Habitacion Insertada", "Sistema");
                Console.WriteLine(respuestaConvertidaString);
            }
        }

        public void CrearReservacion(String dia, String mes, String anho, String fechaoc, String usuario,String extras,String tarjeta, String codigohab, String total, String fechadev) {
            System.Windows.Forms.DialogResult result;
            using (var cliente = new WebClient()) {
                var variablesAEnviar = new NameValueCollection();
                variablesAEnviar["anho"] = anho;
                variablesAEnviar["mes"] = mes;
                variablesAEnviar["dia"] = dia;
                variablesAEnviar["codigohab"] = codigohab;
                variablesAEnviar["extras"] = extras;
                variablesAEnviar["user"] = usuario;
                variablesAEnviar["tarjeta"] = tarjeta;
                variablesAEnviar["total"] = total;
                
                if (fechadev != "")
                {
                    variablesAEnviar["fechadev"] = fechadev;
                    result = MessageBox.Show("Entró CON Fecha de Devolucion", "Sistema Informa");
                    var respuestaMetodo = cliente.UploadValues("http://tatomarroco.pythonanywhere.com/reservacionfdv", variablesAEnviar);
                    var respuestaConvertidaString = Encoding.Default.GetString(respuestaMetodo);
                    result = MessageBox.Show("Reservacion Insertada", "Sistema");
                    Console.WriteLine(respuestaConvertidaString);
                }
                else {
                    result = MessageBox.Show("Entró SIN Fecha de Devolucion", "Sistema Informa");
                    var respuestaMetodo = cliente.UploadValues("http://tatomarroco.pythonanywhere.com/reservacion", variablesAEnviar);
                    var respuestaConvertidaString = Encoding.Default.GetString(respuestaMetodo);
                    result = MessageBox.Show("Reservacion Insertada", "Sistema");
                    Console.WriteLine(respuestaConvertidaString);
                }

            }
        }

    }
}
