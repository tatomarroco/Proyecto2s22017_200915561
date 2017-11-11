class NodoHash():
	def __init__(self, codigohab=None, usuario = None, extras=None):
		self.Codigohab = codigohab
		self.Usuario = usuario
		self.NumeroDeExtras = extras

	def getCodigoHab(self):
	    return self.Codigohab

	def getUsuario(self):
	    return self.Usuario

	def getNumExtras(self):
	    return self.NumeroDeExtras

