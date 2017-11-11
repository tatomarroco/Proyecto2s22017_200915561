from nodoHab import nodoHab

########################################################################
class listaSimple():
    longitud = 0

    #----------------------------------------------------------------------
    def __init__(self):
        self.Primero = None
        self.Ultimo = None
        """Constructor"""

    #----------------------------------------------------------------------
    def Add(self,numhab,piso):
        Nuevo = nodoHab(numhab, piso)
        aux = self.Primero
        if(self.Primero == None):
            self.Primero           = Nuevo
            self.Ultimo            = Nuevo
            self.Ultimo.Siguiente  = self.Primero
        else:
            self.Ultimo.Siguiente = Nuevo
            Nuevo.Siguiente       = self.Primero
            self.Ultimo           = Nuevo
        self.longitud += 1
        return "true"

    def ModificarEstadoAOcupada(self, codigo):
        aux = self.Primero
        while (aux != None):
            idHab = aux.getIDHab()
            if(idHab == codigo):
                aux.Ocupada = "true"
                aux.sumarContador()
                break
            aux = aux.Siguiente


    def ObtenerNoReservadas(self):
        aux = self.Primero
        habitaciones = ""
        while(aux != None):
            if(aux.getEstado() == "false"):
                habitaciones +=  aux.getNumHabitacion() + "," + aux.getNivel()+ ":"
            aux = aux.Siguiente
            if(aux == self.Primero):
                break
        return str(habitaciones)


    def getLongitud(self):
        return self.longitud

    def graficar(self):
        aux = self.Primero
        grafo = "digraph Habitaciones{\n"
        i=0
        if(self.Primero == None):
            return "No hay nada que graficar"
        else:
            while(aux != None):
                etiqueta = "Nivel " + str(aux.getNivel()) +"\\n" + "Numero " + str(aux.getNumHabitacion()) +"\\n" + str(aux.getIDHab()) +"\\n" +str(aux.getEstado())
                grafo += "nodo_" + str(i) + "[label = \""+ etiqueta +"\"] \n"
                if(aux == self.Ultimo):
                    break
                else:
                    aux = aux.Siguiente
                    i += 1
            aux = self.Primero
            i=0
            while(aux != None):
                if(aux == self.Ultimo):
                    grafo += "nodo_" + str(i) + "->nodo_"+ str(0) +"\n"
                    break
                else:
                    grafo += "nodo_" + str(i) + "->nodo_"+ str(i+1) +"\n"
                    aux = aux.Siguiente
                    i += 1
            return str(grafo) + "}"

