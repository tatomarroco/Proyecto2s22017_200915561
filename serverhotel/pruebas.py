from nodoHab import nodoHab
from listaSimple import listaSimple
from listaDoble import listaDoble
from nodoMtx import NodoMtx
from matriz import Matriz
from TablaHash import TablaHash
from AVL import AVL
from ArbolB.ArbolB import ArbolB 

class pruebas():

    habitaciones = listaSimple()
    calendario = Matriz()
    fecha = NodoMtx()
    pagos = AVL()
    bitacora = ArbolB()
    while (True):
        print "***Menu***"
        print "***1.- Insertar Habitacion***"
        print "***2.- Insertar Reservacion***"
        print "***3.- Insertar En AVL***"
        print "***4.- Eliminar***"
        print "***5.- Salir***"
        try:
            opcion = input("Elija Opcion: ")
            if opcion == 1:
                hab = raw_input("Habitacion: ")
                piso = raw_input("Piso: ")
                habitaciones.Add(hab, piso)
            if opcion == 2:
                Anho = "2017"
                Mes  = "11"
                Dia  = "19"
                codigo = "218"
                Extras = "3"
                usuario = "tato"
                calendario.CrearDiaMtx(Anho,Mes,Dia)
                fecha = calendario.BuscarDia(Anho,Mes,Dia)
                Reservacion = fecha.getTablaHash()
                Reservacion.AddNode(codigo, usuario, Extras)
                habitaciones.ModificarEstadoAOcupada(codigo)
                graficaMatriz = calendario.graficar()
                print graficaMatriz
                #arch = cola.Graficar()
            if opcion == 3:
                usuario = "tato"
                
                tarjeta = "29"
                tarjeta1 = "35"
                tarjeta2 = "02"
                tarjeta3 = "33"
                tarjeta4 = "05"
                tarjeta5 = "16"
                tarjeta6 = "19"
                tarjeta7 = "38"
                tarjeta8 = "17"
                tarjeta9 = "25"
                tarjeta10 = "20"
                tarjeta11 = "27"
                """
                tarjeta = "12345"
                tarjeta1 = "12349"
                tarjeta2 = "11345"
                tarjeta3 = "10041"
                tarjeta4 = "10002"
                tarjeta5 = "23548"
                tarjeta6 = "24555"
                """
                precio = "1500"
                pagos.agregar(tarjeta, usuario, precio)
                pagos.agregar(tarjeta1, usuario, precio)
                pagos.agregar(tarjeta2, usuario, precio)
                pagos.agregar(tarjeta3, usuario, precio)
                pagos.agregar(tarjeta4, usuario, precio)
                pagos.agregar(tarjeta5, usuario, precio)
                pagos.agregar(tarjeta6, usuario, precio)
                pagos.agregar(tarjeta7, usuario, precio)
                pagos.agregar(tarjeta8, usuario, precio)
                pagos.agregar(tarjeta9, usuario, precio)
                pagos.agregar(tarjeta10, usuario, precio)
                pagos.agregar(tarjeta11, usuario, precio)                
                graficaavl = pagos.graficar()
                print graficaavl
            if opcion == 4:
                usuario = "tato"
                total = "1700"
                tarjeta = "12345"
                fechaOc = ""
                bitacora.crearNodoInsertar(31122017, usuario, "218", total,tarjeta,"31122017")
                bitacora.crearNodoInsertar(30042016, usuario, "320", total,tarjeta,"30042016","03052016")
                bitacora.crearNodoInsertar(29032018, usuario, "135", total,tarjeta,"29032018")
                bitacora.crearNodoInsertar(28022017, usuario, "450", total,tarjeta,"28022017","05022017")
                bitacora.crearNodoInsertar(15092019, usuario, "862", total,tarjeta,"15092019")
                graficaAB = bitacora.graficar()
                print graficaAB
            if opcion == 5:
                grafica = calendario.graficar()
                print grafica
        except:
            print "Ocurrio un Error"