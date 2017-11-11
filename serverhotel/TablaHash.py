from nodoHash import NodoHash

class TablaHash():
	def __init__(self):
		self.tabla = [0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0]
		self.tamano = 47
		self.exeso = float(0.75)
		self.maxSize = None
		self.size = None
		self.tempSize = None
		self.elementos = None
		self.aux = None
		self.aux2 = None
		self.factorE = None
		self.CrearTabla()


	#CREAR TABLA
	def CrearTabla(self):
		for i in range(0, self.tamano-1):
			self.tabla[i]=None;
			self.elementos=0;
			self.factorE = float(0.0)
			self.maxSize = 28
			self.tempSize = 47
			self.size = 0
			self.aux = 1
			self.aux2 = self.aux



	#CREAR NODO HASH
	def AddNode(self, codigo, nombre,extras):
		nodoHash = NodoHash(codigo, nombre,extras)
		self.Insertar(nodoHash)

	#INSERTAR
	def Insertar(self, nodoHash):
		indice = self.direccion(nodoHash.Codigohab)
		if self.elementos < self.maxSize:
			self.insertarTabla(nodoHash, indice)
			self.elementos+=1
			return 1
		else:
			x = self.maxSize
			self.redimensionar()
			self.maxSize = x*2
		return 0


	def devolverClave(self, codigo):
		cod = str(codigo)
		#Metodo de la MULTIPLICACION-------------------------------------------------------------------
		aureainv = 0.6180334
		codigohab = int(cod)
		operacion = aureainv * codigohab

		decimal = abs(operacion) - abs(int(operacion))
		hx = decimal * self.tempSize
		#----------------------------------------------------------------------------------------------
		return int(hx)



	#EXISTE
	def existe(self, indice):
		aux = NodoHash()
		if indice < self.tabla.length:
			aux = self.tabla[indice]
			if aux == None:
				return True
			else:
				return False
		return False




	#DIRECCION
	def direccion(self, codigo):
		clave = self.devolverClave(codigo)
		enviar = 0
		i = 0
		indice = clave #% len(self.tabla)

		if indice < len(self.tabla):
			while self.tabla[indice] != None: #and int(self.tabla[indice].codigo) != codigo:
				#if self.tabla[indice].codigo == codigo:
				if self.tabla[indice] == None:
					print("Retornar Indice sin Cambios")
				else:
					i+=1
					indice = clave + (i*i)
					indice = indice % len(self.tabla)

		#print("Clave generado: " + str(clave))
		#print("Direccion enviada: " + str(indice))
		return indice


	#INSERTAR TABLA
	def insertarTabla(self, nuevo, indice):
		self.tabla[indice] = nuevo
		#print("inserto: " + str(nuevo.codigohab) + " en: "+ str(indice))


	#ReHash
	def redimensionar(self):
		self.aux = self.aux2*2
		nuevoTamano = 2* len(self.tabla)
		#print("Tamano tabla vieja: " + len(self.tabla) + " y nueva: " + nuevoTamano)
		self.elementos = 0
		tablaTemp = self.tabla
		self.tabla = HNodo[nuevoTamano]
		for i in tablaTemp.length:
			if tablaTemp[i] != None:
				aux= tablaTemp[i];
				print("Encontro " + i);
				self.insertarTabla(aux, i)
				self.elementos +=1

			self.maxSize = (self.maxSize*2)


	#Mostrar
	def mostrar(self):
		enviar=""
		codigo=""
		nombre=""

		aux =  NodoHash()
		x=1
		#print("Tamano tabla: " + str(len(self.tabla)))

		for i in range(0, len(self.tabla)):
			aux = self.tabla[i]
			if aux != None and aux != 0:
				codigo= aux.Codigohab
				nombre = aux.nombre
				enviar = enviar + str(codigo) + " - " + nombre + " "+ str(i) +  ";"
				#print("Direccion: " + str(i) + " Codigo: " + str(codigo) + " - " + nombre + ";")
				x += 1

		#print("Elementos "+ str(self.elementos))

	#Graficar
	def graficar(self):
		aux = NodoHash()
		cadena=""
		cadena2=""
		texto = ""

		texto += "digraph  Reservaciones{  nodesep=.05;\n"
		texto += "rankdir = LR;\n"
		texto += "node[shape=record,width=.1,height=.1]; \n"
		texto += "node0 [label = \""

		tablaTemp = self.tabla

		for i in range(0, len(tablaTemp)):
			aux = tablaTemp[i]
			if aux !=  None and aux != 0:
				codigo = str(aux.getCodigoHab())
				#nombre = aux.getUsuario
				cadena = cadena + "<f" + str(i) +"> Codigo De Habitacion: "+ str(codigo) + "  | "


		cadena2 = cadena[0:(int(len(cadena))-2)]

		texto += str(cadena2)
		texto += '\",height=2.5];'
		texto += '\n }'

		return texto








