from TablaHash import TablaHash 

class NodoMtx():
    def __init__ (self, mes=None, numeroMes=None, anio=None, dia=None, codigo=None, arriba=None, abajo=None, derecha=None, izquierda=None, profundidad=None):
        self.mes = mes
        self.numeroMes = numeroMes
        self.anio = anio
        self.dia = dia
        self.codigo = codigo
        self.arriba = arriba
        self.abajo = abajo
        self.derecha = derecha
        self.izquierda = izquierda
        self.profundidad = profundidad
        self.hashtable = TablaHash()
        
    #----------------------------------------------------------------------
    def getTablaHash(self):
        return self.hashtable
    
    #----------------------------------------------------------------------
    def setTablaHash(self, thash):
        self.hashtable = thash
        """"""
        
        
        