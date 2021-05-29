Algoritmo n_1ros_nros_fibonacci
	init <- 0
	init1 <- 1
	Escribir 'Hasta que numero deberia mostrar la sucecion?'
	Leer n
	Para i<-1 Hasta n Hacer
		Escribir init
		init2 <- init+init1
		init <- init1
		init1 <- init2
	FinPara
FinAlgoritmo
