Algoritmo Determinar_max_3n
	Escribir "Ingresa tres valores!"
	Leer x , ye , z
	Si x > ye Entonces
		si x > z Entonces
			Escribir "El numero " x ", es el mayor de los 3"
		sino 
			Escribir "El numero " ye ", es el mayor de los 3"
		FinSi
	SiNo
		si ye > z Entonces
			Escribir "El numero " ye ", es el mayor de los 3"
		SiNo
			Escribir "El numero " z ", es el mayor de los 3"
		FinSi
	FinSi
FinAlgoritmo
