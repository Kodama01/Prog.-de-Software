Algoritmo Tabla_x_usuario
	Definir tabla Como Entero
	Escribir 'Ingresa la tabla de multiplicar que quieres consultar!'
	Leer tabla
	Escribir "Desde que numero iniciar?"
	Leer min
	Escribir "Hasta que numero deberia ir?"
	Leer lim
	Para n<-min Hasta lim con paso 1 hacer
		Escribir tabla,'x',n,'=',(tabla*n)
	FinPara
FinAlgoritmo
