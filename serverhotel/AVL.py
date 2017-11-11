from Logical import Logical 
from NodoAVL import NodoAVL

class AVL():
    def __init__ (self):
        self.Raiz = None
        self.encontrado = None
        self.inicio = None
        self.nodoAeliminar = None
        self.nodoSustitucion = None
        self.degraf = ""
        
    def getEncontrado(self):
        return self.encontrado
    
    def setEncontrado(self, valor):
        self.encontrado = valor
        
    #----------------------------------------------------------------------
    def agregar(self,tarjeta, usuario, total):
        nodo = NodoAVL(tarjeta, usuario, total)
        self.AddAVLNode(nodo)
            
        
    def AddAVLNode(self, nuevoNodo):
        temp = self.DevolverAVL(nuevoNodo) 
        if temp == None:
            h = Logical(False)
            self.Raiz = self.agregarAVL(self.Raiz, nuevoNodo, h)
        else:
            return str("ya existe")
            
    def DevolverAVL(self, nuevoNodo):
        self.setEncontrado(None)
        self.buscarAVL(self.Raiz, nuevoNodo)
        return self.getEncontrado()
    
    def buscarAVL(self, raiz, nuevoNodo):
        if raiz != None:
            if nuevoNodo.Tarjeta == raiz.Tarjeta:
                self.setEncontrado(raiz)
            else:
                self.buscarAVL(raiz.hijoIzquierdo, nuevoNodo)
                self.buscarAVL(raiz.hijoDerecho, nuevoNodo)
                
    def agregarAVL(self, raiz, nuevoNodo, h):
        if self.Raiz == None:
            self.Raiz = nuevoNodo
            h.setLogical(True)
            raiz = self.Raiz
        elif raiz == None:
            raiz = nuevoNodo
            h.setLogical(True)
        elif str(nuevoNodo.Tarjeta) < str(raiz.Tarjeta):
            nodoIz = self.agregarAVL(raiz.hijoIzquierdo, nuevoNodo, h)
            raiz.hijoIzquierdo = nodoIz
            if h.getLogical() == True:
                op = raiz.factorEquilibrio
                if op == 1:
                    raiz.factorEquilibrio = 0
                    h.setLogical(False)
                elif op == 0:
                    raiz.factorEquilibrio = -1
                elif op == -1:
                    nodo1 = raiz.hijoIzquierdo
                    if nodo1.factorEquilibrio == -1:
                        raiz = self.rotacionII(raiz, nodo1)
                    else:
                        raiz = self.rotacionID(raiz, nodo1)
                    h.setLogical(False)
        elif str(nuevoNodo.Tarjeta) > str(raiz.Tarjeta):
            nodoDr = self.agregarAVL(raiz.hijoDerecho, nuevoNodo, h)
            raiz.hijoDerecho = nodoDr
            if h.getLogical() == True:
                op = raiz.factorEquilibrio
                if op == 1:
                    nodo1 = raiz.hijoDerecho
                    if nodo1.factorEquilibrio == 1:
                        raiz = self.rotacionDD(raiz, nodo1)
                    else:
                        raiz = self.rotacionDI(raiz, nodo1)
                    h.setLogical(False)
                elif op == 0:
                    raiz.factorEquilibrio = 1
                elif op == -1:
                    raiz.factorEquilibrio = 0
                    h.setLogical(False)
        return raiz
    
    def rotacionID(self, nodo, nodo1):
        nodo2 = nodo1.hijoDerecho
        nodo1.hijoDerecho = nodo2.hijoIzquierdo
        nodo2.hijoIzquierdo = nodo1
        nodo.hijoIzquierdo = nodo2.hijoDerecho
        nodo2.hijoDerecho = nodo
        #nodo = nodo2
        if nodo2.factorEquilibrio == 1:
            nodo1.factorEquilibrio = -1
        else:
            nodo1.factorEquilibrio = 0
        if nodo2.factorEquilibrio == -1:
            nodo.factorEquilibrio = 1
        else:
            nodo.factorEquilibrio = 0
        nodo2.factorEquilibrio = 0
        return nodo2
    
    def rotacionII(self, nodo, nodo1):
        nodo.hijoIzquierdo = nodo1.hijoDerecho
        nodo1.hijoDerecho = nodo
        if nodo1.factorEquilibrio == -1:
            nodo.factorEquilibrio = 0
            nodo1.factorEquilibrio = 0
        else:
            nodo.factorEquilibrio = -1
            nodo1.factorEquilibrio = 1
        return nodo1
    
    def rotacionDD(self, nodo, nodo1):
        nodo.hijoDerecho = nodo1.hijoIzquierdo
        nodo1.hijoIzquierdo = nodo
        if nodo1.factorEquilibrio == 1:
            nodo.factorEquilibrio = 0
            nodo1.factorEquilibrio = 0
        else:
            nodo.factorEquilibrio = 1
            nodo1.factorEquilibrio = -1
        return nodo1
    
    def rotacionDI(self, nodo, nodo1):
        nodo2 = nodo1.hijoIzquierdo
        nodo1.hijoIzquierdo = nodo2.hijoDerecho
        nodo2.hijoDerecho = nodo1
        nodo.hijoDerecho = nodo2.hijoIzquierdo
        nodo2.hijoIzquierdo = nodo
    
        if nodo2.factorEquilibrio == 1:
            nodo.factorEquilibrio = -1
        else:
            nodo.factorEquilibrio = 0
        if nodo2.factorEquilibrio == -1:
            nodo1.factorEquilibrio = 1
        else:
            nodo1.factorEquilibrio = 0
        nodo2.factorEquilibrio = 0
        return nodo2
         
    def graficar(self):
        self.limpiarVariableGraficar()
        self.graficarPreOrden(self.Raiz)
        self.degraf += "}"
        return self.degraf

    #Escribir el inicio del Archivo
    def ObtenerAVL(self):
        return ""

    def graficarPreOrden(self,nuevoNodo):
        if nuevoNodo != None:
            self.degraf += "nodo_" + nuevoNodo.Tarjeta + ' [label="' + nuevoNodo.Tarjeta + '\\n Q' + nuevoNodo.Total + '"]\n'
            if nuevoNodo.hijoIzquierdo != None:
                self.degraf += "nodo_" + nuevoNodo.Tarjeta + " -> " "nodo_" + nuevoNodo.hijoIzquierdo.Tarjeta + "\n"
                self.graficarPreOrden(nuevoNodo.hijoIzquierdo)
            else:
                pass
            if nuevoNodo.hijoDerecho != None:
                self.degraf += "nodo_" + nuevoNodo.Tarjeta + " -> " "nodo_" + nuevoNodo.hijoDerecho.Tarjeta + "\n"
                self.graficarPreOrden(nuevoNodo.hijoDerecho)                   
            else:
                pass
        else:
            pass
    
    def limpiarVariableGraficar(self):
        self.degraf = "digraph Pagos{\n"
        
    def mostrarPreOrden(self, nuevoNodo):
        if nuevoNodo != None:
            print(str(nuevoNodo.Tarjeta))
            self.mostrarPreOrden(nuevoNodo.hijoIzquierdo)
            self.mostrarPreOrden(nuevoNodo.hijoDerecho)
    
    def mostrarInOrden(self, nuevoNodo):
        if nuevoNodo != None:  
            self.mostrarInOrden(nuevoNodo.hijoIzquierdo)
            print(str(nuevoNodo.Tarjeta))
            self.mostrarInOrden(nuevoNodo.hijoDerecho)
    
    def mostrarPostOrden(self, nuevoNodo):
        if nuevoNodo != None:  
            self.mostrarPostOrden(nuevoNodo.hijoIzquierdo)
            self.mostrarPostOrden(nuevoNodo.hijoDerecho)
            print(str(nuevoNodo.Tarjeta))
            
    def obtenerRaiz(self):
        return self.Raiz
    
    def agregarListaAVL(self, nuevoNodo):
        if self.inicio != None:
            temp = self.inicio
            while temp.siguiente != None:
                temp = temp.siguiente
            temp.siguiente = nuevoNodo
        else:
            self.inicio = nuevoNodo
            
    def agregarAVLmodificado(self):  #Este metodo se llama por primera vez antes de GRAFICAR
        self.Raiz = None
        if self.inicio != None:
            temp = self.inicio
            while temp != None:
                nuevoNodo = NodoAVL(temp.Tarjeta, temp.Usuario, temp.Total)
                self.AddAVLNode(nuevoNodo)
                temp = temp.siguiente
                
    def eliminarAVL(self, Tarjeta):
        if self.inicio != None:
            if self.inicio.Tarjeta == Tarjeta:
                if self.inicio.siguiente != None:
                    self.inicio = self.inicio.siguiente
                else:
                    self.inicio = None
                
            temp = self.inicio
            while temp.siguiente != None:
                temp2 = temp.siguiente
                if temp2.Tarjeta == Tarjeta:
                    temp.siguiente = temp2.siguiente
                temp = temp.siguiente
                
            self.agregarAVLmodificado()
            
    def metodoEliminarAVL(self, Tarjeta):
        nuevoNodo = NodoAVL(Tarjeta)
        self.buscarAVLparaEliminar(self.Raiz, nuevoNodo)
        nodoIzDeNodoAeliminar = self.nodoAeliminar.hijoIzquierdo
        self.complementoBuscarAVLparaEliminar(nodoIzDeNodoAeliminar)
        if self.inicio != None:
            if self.inicio.Tarjeta == self.nodoSustitucion.Tarjeta:
                if self.inicio.siguiente != None:
                    self.inicio = self.inicio.siguiente
                else:
                    self.inicio = None
                    
            temp = self.inicio
            while temp.siguiente != None:
                temp2 = temp.siguiente
                if temp2.Tarjeta == self.nodoSustitucion.Tarjeta:
                    temp.siguiente = temp2.siguiente
                    break
                    #temp.siguiente = None# ########################
                temp = temp.siguiente
                
            self.metodoModificarAVL(self.nodoSustitucion.Tarjeta, self.nodoSustitucion.Total)
            
                        
        
        
    def buscarAVLparaEliminar(self, raiz, nuevoNodo):
        if raiz != None:
            if nuevoNodo.Tarjeta == raiz.Tarjeta:
                self.nodoAeliminar = raiz #self.setEncontrado(raiz)
            else:
                self.buscarAVLparaEliminar(raiz.hijoIzquierdo, nuevoNodo)
                self.buscarAVLparaEliminar(raiz.hijoDerecho, nuevoNodo)
                
    def complementoBuscarAVLparaEliminar(self, raiz):
        if raiz.hijoDerecho != None:
            self.complementoBuscarAVLparaEliminar(raiz.hijoDerecho)
        else:
            self.nodoSustitucion = raiz
            
    def metodoModificarAVL(self, nuevoNumeroTarjeta, nuevoMonto):
        if self.inicio != None:
            temp = self.inicio
            while temp != None:
                if temp.Tarjeta == self.nodoAeliminar.Tarjeta:
                    temp.Tarjeta = nuevoNumeroTarjeta #temp.siguiente = self.nodoSustitucion #temp.siguiente = temp2.siguiente
                    temp.Total = nuevoMonto
                temp = temp.siguiente    
                
    def mostrarLista(self):
        if self.inicio != None:
            temp = self.inicio
            while temp != None:
                print str(temp.Tarjeta)
                temp = temp.siguiente