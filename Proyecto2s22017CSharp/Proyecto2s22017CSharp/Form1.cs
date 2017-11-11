using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Proyecto2s22017CSharp
{
    public partial class Admin : Form{

        cargarXML cxml = new cargarXML();
        conexion conectar = new conexion();
        public string grafica = "";
        public Admin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            pbUsuarios.SizeMode = PictureBoxSizeMode.AutoSize;
            pbHabitaciones.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tpReserva_Click(object sender, EventArgs e)
        {

        }

        private void btnLoadUsers_Click(object sender, EventArgs e){
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\users";
            openFileDialog1.Filter = "xml files (*.xml)|*.xml";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;


            if (openFileDialog1.ShowDialog() == DialogResult.OK){
                try{
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        Console.WriteLine(myStream.ToString());
                        using (myStream){
                            cxml.analizarUsuarios(myStream);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: No se pudo leer el archivo. Error de Origen: " + ex.Message);
                }
            }


        }

        private void btnLoadRooms_Click(object sender, EventArgs e){
            Stream myStream2 = null;
            OpenFileDialog openFileDialog2 = new OpenFileDialog();

            openFileDialog2.InitialDirectory = "c:\\users";
            openFileDialog2.Filter = "xml files (*.xml)|*.xml";
            openFileDialog2.FilterIndex = 2;
            openFileDialog2.RestoreDirectory = true;


            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream2 = openFileDialog2.OpenFile()) != null)
                    {
                        Console.WriteLine(myStream2.ToString());
                        using (myStream2)
                        {
                            cxml.analizarHabitaciones(myStream2);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: No se pudo leer el archivo. Error de Origen: " + ex.Message);
                }
            }
        }

        private void btnMostrarUsers_Click(object sender, EventArgs e){

            using (System.IO.StreamWriter escritor = new System.IO.StreamWriter(@"C:\\Users\\Estuardo\\Documents\\NetBeansProjects\\Proyecto2s22017\\graficas\\usuarios.txt"))
            {
                grafica = conectar.Graficas("users");
                escritor.WriteLine(grafica);

            }
            conectar.crearImagen("usuarios");
            Thread.Sleep(3000);
            pbUsuarios.Image = Image.FromFile(@"C:\\Users\\Estuardo\\Documents\\NetBeansProjects\\Proyecto2s22017\\graficas\\usuarios.txt.jpg");
            
        }

        private void btnMostrarHab_Click(object sender, EventArgs e)
        {
            using (System.IO.StreamWriter escritor = new System.IO.StreamWriter(@"C:\\Users\\Estuardo\\Documents\\NetBeansProjects\\Proyecto2s22017\\graficas\\habitaciones.txt"))
            {
                grafica = conectar.Graficas("rooms");
                escritor.WriteLine(grafica);

            }
            conectar.crearImagen("habitaciones");
            Thread.Sleep(3000);
            pbHabitaciones.Image = Image.FromFile(@"C:\\Users\\Estuardo\\Documents\\NetBeansProjects\\Proyecto2s22017\\graficas\\habitaciones.txt.jpg");

        }

        private void btnLoadReservation_Click(object sender, EventArgs e){
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\users";
            openFileDialog1.Filter = "xml files (*.xml)|*.xml";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        Console.WriteLine(myStream.ToString());
                        using (myStream)
                        {
                            cxml.analizarReservaciones(myStream);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: No se pudo leer el archivo. Error de Origen: " + ex.Message);
                }
            }
        }
    }
}
