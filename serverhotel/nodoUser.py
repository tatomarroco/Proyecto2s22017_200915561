########################################################################
class nodoUser():

    #----------------------------------------------------------------------
    def __init__(self, user, contrasenha, age=None, adress=None, tel=None):
        self.Usuario = user
        self.Contrasenha = contrasenha
        self.Edad = age
        self.Direccion = adress
        self.Telefono = tel
        self.Sig = None
        self.Ant = None
        """Constructor"""

    #----------------------------------------------------------------------
    def getUsuario(self):
        return self.Usuario

    #----------------------------------------------------------------------
    def setUsuario(self, user):
        self.Usuario = user
        """"""

    #----------------------------------------------------------------------
    def getPassword(self):
        return self.Contrasenha

    #----------------------------------------------------------------------
    def setPassword(self, password):
        self.Contrasenha = password
        """"""

    #----------------------------------------------------------------------
    def getDireccion(self):
        return self.Direccion

    #----------------------------------------------------------------------
    def setDireccion(self, direccion):
        self.Direccion = direccion
        """"""

    #----------------------------------------------------------------------
    def getEdad(self):
        return self.Edad

    #----------------------------------------------------------------------
    def setEdad(self, edad):
        self.Edad = edad
        """"""

    #----------------------------------------------------------------------
    def getTelefono(self):
        return self.Telefono

    #----------------------------------------------------------------------
    def setTelefono(self,telefono):
        self.Telefono = telefono
        """"""





