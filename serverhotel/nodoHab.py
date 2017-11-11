########################################################################
class nodoHab():
    """"""

    #----------------------------------------------------------------------
    def __init__(self,nhabitacion,nivel):
        self.IDHab = str(nivel)+str(nhabitacion) #ID de la Habitacion
        self.NumHabitacion = nhabitacion
        self.Nivel = nivel
        self.Ocupada = "false"
        self.contador = 0
        self.Siguiente = None
        """Constructor"""

    #----------------------------------------------------------------------
    def getIDHab(self):
        return self.IDHab

    #----------------------------------------------------------------------
    def setIDHab(self,idhab):
        self.IDHab = idhab
        """"""

    #----------------------------------------------------------------------
    def getNumHabitacion(self):
        return self.NumHabitacion

    #----------------------------------------------------------------------
    def setNumHabitacion(self,nhabitacion):
        self.NumHabitacion = nhabitacion
        """"""

    #----------------------------------------------------------------------
    def getNivel(self):
        return self.Nivel

    #----------------------------------------------------------------------
    def setNivel(self,nivel):
        self.Nivel = nivel
        """"""

    #----------------------------------------------------------------------
    def getEstado(self):
        return self.Ocupada

    #------------MODIFICAR ESTADO----------------------------------------------------------
    def setEstado(self, estado):
        self.Ocupada = estado

    def getContador(self):
        return self.contador

    def setContador(self, contador):
        self.contador = contador

    def sumarContador(self):
        self.contador += 1










