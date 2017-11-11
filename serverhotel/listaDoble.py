from nodoUser import nodoUser
########################################################################
class listaDoble():
    longitud = 0

    #----------------------------------------------------------------------
    def __init__(self):
        self.Primero = None
        self.Ultimo  = None

    def getLongitud(self):
        return self.longitud

    #----------------------------------------------------------------------
    def Add(self, user, password, edad, direccion, telefono):
        Nuevo = nodoUser(user, password, edad, direccion, telefono)
        aux = self.Primero
        if (self.Primero == None):
            self.Primero = Nuevo
            self.Ultimo = Nuevo
        else:
            while(aux != None):
                if(aux.Sig == None):
                    self.Ultimo.Sig = Nuevo
                    Nuevo.Ant = self.Ultimo
                    self.Ultimo = Nuevo
                    break
                aux = aux.Sig
        self.longitud += 1
        return "true"

    def consultar(self, usuario,password):
        aux = self.Primero
        if (self.Primero == None):
            return "Lista Vacia"
        else:
            while (aux != None):
                user = aux.getUsuario()
                contra = aux.getPassword()
                if (user == str(usuario)) and (contra == str(password)):
                    return "true"
                    break
                aux = aux.Sig

    def graficar(self):
        aux = self.Primero
        grafo = "digraph Usuarios{\n"
        i=0
        if(self.Primero == None):
            return "No hay nada que graficar"
        else:
            while(aux != None):
                etiqueta = str(aux.getUsuario())
                grafo += "nodo_" + str(i) + "[label = \""+ etiqueta +"\"] \n"
                aux = aux.Sig
                i += 1
            aux = self.Primero
            i=0
            while(aux != None):
                if(aux != None and aux.Sig != None):
                    grafo += "nodo_" + str(i) + "->nodo_"+ str(i+1) +"\n"
                    grafo += "nodo_" + str(i+1) + "->nodo_"+ str(i) +"\n"
                    aux = aux.Sig
                    i += 1
                else:
                    break
            return str(grafo) + "}"

