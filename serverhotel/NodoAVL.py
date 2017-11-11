########################################################################
class NodoAVL():

    #----------------------------------------------------------------------        
    def __init__(self,tarjeta=None,usuario=None,total=None,izquierdo=None,derecho=None,padre=None):
        self.Tarjeta = tarjeta
        self.Usuario = usuario
        self.Total = total
        self.hijoIzquierdo = izquierdo
        self.hijoDerecho = derecho
        self.padre = padre
        self.factorEquilibrio = 0
    
    def tieneHijoIzquierdo(self):
        return self.hijoIzquierdo

    def tieneHijoDerecho(self):
        return self.hijoDerecho

    def esHijoIzquierdo(self):
        return self.padre and self.padre.hijoIzquierdo == self

    def esHijoDerecho(self):
        return self.padre and self.padre.hijoDerecho == self

    def esRaiz(self):
        return not self.padre

    def esHoja(self):
        return not (self.hijoDerecho or self.hijoIzquierdo)

    def tieneAlgunHijo(self):
        return self.hijoDerecho or self.hijoIzquierdo

    def tieneAmbosHijos(self):
        return self.hijoDerecho and self.hijoIzquierdo

    def reemplazarDatoDeNodo(self,tarjeta,usuario,total,hizq,hder):
        self.Tarjeta = tarjeta
        self.Usuario = usuario
        self.Total = total
        self.hijoIzquierdo = hizq
        self.hijoDerecho = hder
        if self.tieneHijoIzquierdo():
            self.hijoIzquierdo.padre = self
        if self.tieneHijoDerecho():
            self.hijoDerecho.padre = self    
    
        
    #----------------------------------------------------------------------
    def getTarjeta(self):
        return self.Tarjeta
    
    #----------------------------------------------------------------------
    def setTarjeta(self, tarjeta):
        self.Tarjeta = tarjeta
    
    #----------------------------------------------------------------------
    def getUsuario(self):
        return self.Usuario
    
    #----------------------------------------------------------------------
    def setUsuario(self, usuario):
        self.Usuario = usuario
    
    #----------------------------------------------------------------------
    def getTotal(self):
        return self.Total
    
    #----------------------------------------------------------------------
    def setTotal(self, total):
        self.Total = total
    
    #----IZQUIERDA------------------------------------------------------------------
    def getLeft(self):
        return self.hijoIzquierdo
    
    #----IZQUIERDA------------------------------------------------------------------
    def setLeft(self, izquierda):
        self.hijoIzquierdo = izquierda
    
    #----DERECHA------------------------------------------------------------------
    def getRight(self):
        return self.hijoDerecho
    
    #----DERECHA------------------------------------------------------------------
    def setRight(self, derecha):
        self.hijoDerecho = derecha