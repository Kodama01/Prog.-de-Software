	Algoritmo Determinar_min_3n
		Escribir "Ingresa tres valores!"
		Leer x , ye , z
		Si x < ye Entonces
			si x < z Entonces
				Escribir "El numero " x ", es el menor de los 3"
			sino 
				Escribir "El numero " ye ", es el menor de los 3"
			FinSi
		SiNo
			si ye < z Entonces
				Escribir "El numero " ye ", es el menor de los 3"
			SiNo
				Escribir "El numero " z ", es el menor de los 3"
			FinSi
		FinSi
FinAlgoritmo

