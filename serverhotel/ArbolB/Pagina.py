from NodoB import NodoB

nodoB = NodoB()

########################################################################
class Pagina():
    """"""

    #----------------------------------------------------------------------
    def __init__(self, ramas=[None,None,None,None,None],claves=[None,None,None,None],cuentas=0):
        self.ramas = ramas
        self.claves = claves
        self.cuentas = cuentas        
        """Constructor"""
        
    #----------------------------------------------------------------------
    def getRamas(self):
        return self.Ramas

    #----------------------------------------------------------------------
    def setRamas(self, ramas):
        self.Ramas = ramas
        """"""
        
    #----------------------------------------------------------------------
    def getClaves(self):
        return self.Claves
    
    #----------------------------------------------------------------------
    def setClaves(self, claves):
        self.Claves = claves
        """"""
        
    #----------------------------------------------------------------------
    def getCuentas(self):
        return self.Cuentas

    #----------------------------------------------------------------------
    def setCuentas(self, cuentas):
        self.Cuentas = cuentas
        """"""