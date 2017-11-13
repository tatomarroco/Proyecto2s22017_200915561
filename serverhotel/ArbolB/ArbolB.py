from NodoB import NodoB
from Pagina import Pagina
from ListaB import ListaB

pagina = Pagina()
nodoB = NodoB()
ListaParaB = ListaB()


class ArbolB:
	def __init__(self):
		self.inicio = Pagina()
		self.inicio2 = Pagina()
		self.inserta = NodoB()
		self.enlace = Pagina()
		self.pivote = False
		self.existe = False
		self.existe2 = False
		self.contadorArbolB=0
		self.nombresDeCarpetas = ""
		self.TodoElArbol = None
		self.RaizActualizada = None
		self.degraf = ""
		
	
	def limpiarVariableGraficar(self):
		self.degraf = "digraph Pagos{\n"		
	
	#CREAR NODO B
	def crearNodoInsertar(self, idb, usuario, idHab,total, tarjeta, fechaOc, fechaSal=None):
		nodo = NodoB(idb, usuario, idHab, total, tarjeta,fechaOc,fechaSal)
		self.InsertarArbolB(nodo, self.inicio)		
	
	
	#INSERTAR NODO EN EL ARBOL B
	def InsertarArbolB(self, clave, raiz):
		self.agregar(clave, raiz)
		if(self.pivote == True):
			self.inicio = Pagina(ramas=[None,None,None,None,None], claves=[None,None,None,None], cuentas=0)
			self.inicio.cuentas = 1
			self.inicio.claves[0] = self.inserta
			self.inicio.ramas[0] = raiz
			self.inicio.ramas[1] = self.enlace	
		
			
			
	#AGREGAR Y BALANCEAR
	def agregar(self, clave, raiz):
		pos = 0              
		self.pivote = False; 
		
		vacioBol = self.vacio(raiz)
		
		if(vacioBol == True):
			self.pivote = True
			self.inserta = clave
			self.enlace = None
		else:
			pos = self.existeNodo(clave, raiz)
			
			if(self.existe == True):
				self.pivote = False
			else:
				self.agregar(clave, raiz.ramas[pos])
				
				if(self.pivote == True):
					
					if(raiz.cuentas < 4):
						self.pivote = False;
						self.insertarClave(self.inserta, raiz, pos)
					else:
						self.pivote = True
						self.dividirPagina(self.inserta, raiz, pos)
						
			
			
	#VERIFICAR SI LA RAIZ EXISTE
	def vacio(self, raiz):
		if(raiz == None or raiz.cuentas == 0):
			return True
		else:
			return False
		
	
	#INSERTAR CLAVES EN PAGINA
	def insertarClave(self, clave, raiz, posicion):
		i = raiz.cuentas
		
		while i != posicion:
			raiz.claves[i] = raiz.claves[i - 1]
			raiz.ramas[i + 1] = raiz.ramas[i]
			i-=1
		
		raiz.claves[posicion] = clave
		raiz.ramas[posicion + 1] = self.enlace
		val = raiz.cuentas+1
		raiz.cuentas = val
		
		
	#DIVIDIR PAGINA
	def dividirPagina(self, clave, raiz, posicion):
		pos = 0
		Posmda = 0
		if(posicion <= 2):
			Posmda = 2
		else:
			Posmda = 3
		
		Mder = Pagina(ramas=[None,None,None,None,None], claves=[None,None,None,None], cuentas=0)
		pos = Posmda + 1
		
		while pos != 5:
			i = ((pos - Posmda) - 1)
			j = (pos - 1)
			Mder.claves[i] = raiz.claves[j]
			Mder.ramas[pos - Posmda] = raiz.ramas[pos]
			pos+=1
		
		Mder.cuentas = 4 - Posmda
		raiz.cuentas = Posmda
		
		if(posicion <= 2):
			self.insertarClave(clave, raiz, posicion)
		else:
			self.insertarClave(clave, Mder, (posicion - Posmda))
			
		self.inserta = raiz.claves[raiz.cuentas - 1]
		Mder.ramas[0] = raiz.ramas[raiz.cuentas]
		val = raiz.cuentas - 1
		raiz.cuentas = val
		self.enlace = Mder
		
	
	#VERIFICAR SI EXISTE NODO	
	def existeNodo(self, clave, raiz):
		valor =0
		if(int(clave.ID) < int(raiz.claves[0].ID)):
			self.existe2 = False
			valor = 0
		else:
			valor = raiz.cuentas
			while (int(clave.ID) < int(raiz.claves[valor - 1].ID) and valor > 1):
				valor-=1
			
			if (int(clave.ID) < int(raiz.claves[valor - 1].ID)):
				self.existe = True
			else:
				self.existe = False
			
			if (int(clave.ID) == int(raiz.claves[valor - 1].ID)):
				self.existe2 = True
				print(raiz.claves[valor - 1].ID)
			else:
				self.existe2 = False
		
		return valor
	
	
	#BUSCAR NODO
	def retornarNodo(self, clave, raiz):
		valorEncontrado = None
		pos = 0
		vacioBol = self.vacio(raiz)
		
		if(vacioBol == True):
			pass
		else:
			pos = self.existeNodo(clave, raiz)
			if(self.existe2 == True):
				valorEncontrado = raiz.claves[pos - 1]				
			else:
				valorEncontrado = self.retornarNodo(clave, raiz.ramas[pos])
		return valorEncontrado
	
	
	
	#CREAR ARCHIVO
	def graficar(self):
		self.limpiarVariableGraficar()
		self.degraf += "node [shape = record];\n"
		self.degraf += "rankdir = TD;\n"		
		self.CrearArchivoParche1(self.inicio)
		return self.degraf
		
	
	#CREAR ARCHIVO
	def crearArchivo2(self, raiz):
		self.degraf += "node [shape = record];\n"
		self.degraf += "rankdir = TD;\n"
		self.CrearArchivoParche1(raiz)	
	
	#FORMATO DEL ARCHIVO
	def CrearArchivoParche1(self, raiz):
		self.inicio = raiz
		self.grabarArchivo(self.inicio)
		self.degraf += '}'
		
	#ESCRIBIR ARCHIVO
	def grabarArchivo(self, raiz):
		nodo = raiz			
		if(nodo == None):
			pass
		else:
			if (nodo.cuentas != 0):
				self.degraf +="activo_" + str(nodo.claves[0].ID) + " [label= \""
				k=1
				while k <= nodo.cuentas:
					self.degraf +="<r" + str(k - 1) + ">" + " | " + "<cl" + str(k) + ">" + "ID ArbolB: " + str(nodo.claves[k - 1].ID) + " &#92;" + "nNombre Registro: " + str(nodo.claves[k - 1].ID) + " | "
					k+=1
				
				
				self.degraf +="<r" + str(k - 1) + "> \"];\n"
				i=0
				while i <= nodo.cuentas:
					if (nodo.ramas[i] != None):
						if (nodo.ramas[i].cuentas != 0):
							self.degraf += "activo_" + str(nodo.claves[0].ID) + ":r" + str(i) + " -> activo_" + str(nodo.ramas[i].claves[0].ID) + ";\n"							
						
					i+=1
					
				j=0
				while j <= nodo.cuentas:
					self.grabarArchivo(nodo.ramas[j])
					j+=1
					
					
	#MODIFICAR NOMBRE
	def actualizarNombre(self, ID, nuevoNombre):
		nodoB = NodoB(ID, "1", "1", "1", "1")
		self.actualizarNombreArbolB(nodoB, nuevoNombre, self.inicio)
		return "Nombre Actualizado"
	
	#ACTUALIZAR NOMBRE 
	def actualizarNombreArbolB(self, nodoB, nuevoNombre, raiz):
		pos = 0
		pos = self.existeNodo(nodoB, raiz)
		if(self.existe2 == True):
			raiz.claves[pos - 1].Nombre = nuevoNombre			
		else:
			self.actualizarNombreArbolB(nodoB, nuevoNombre, raiz.ramas[pos])					
	
	
	#Eliminar
	def Eliminar(self, idEliminar):
		self.InsertarNodosLista(self.inicio)
		raizLista = ListaParaB.retornarLista()
		self.inicio = Pagina()
		
		while raizLista != None:
			if raizLista.index != None and raizLista.nodoArbolB.ID != idEliminar:
				self.InsertarArbolB(raizLista.nodoArbolB, self.inicio)
			raizLista = raizLista.siguiente		
		
		ListaParaB.Limpiar()
		return self.inicio
	
	#INSERTAR NODOS EN LISTA
	def InsertarNodosLista(self, raiz):
		nodo = raiz		
		
		if(nodo == None):
			print("No Hay Nada")
		else:
			if (nodo.cuentas != 0):
				k=1
				while k <= nodo.cuentas:
					ListaParaB.insertar(nodo.claves[k - 1])					
					k+=1
					
				j=0
				while j <= nodo.cuentas:
					self.InsertarNodosLista(nodo.ramas[j])
					j+=1
					
					
	def BuscarNodo(self, nombre):
		self.InsertarNodosLista(self.inicio)
		raizLista = ListaParaB.retornarLista()
		nodos = ""
		while (raizLista != None):
			if (raizLista.index != None and raizLista.nodoArbolB.Usuario == nombre):
				nodos += str(raizLista.nodoArbolB.Habitacion) + ","
			raizLista = raizLista.siguiente
		ListaParaB.Limpiar()
		return str(nodos)	
					
								