def Ejemplo01():
    suma = 0
    contador = 0
    numero = 1

    while True:
        suma = suma + numero
        contador = contador + 1
        numero = numero + 2

        if contador >= 100 or numero > 500:
            break
    
    #salidas
    print(f"Suma de los primeros 100 números impares < que 500 es: {suma}")

def Ejemplo02():
    mayor = None
    contador = 0

    while True:
        numero = int(input("Ingrese un número entero (0 para terminar): "))

        if numero == 0:
            break

        if mayor is None or numero > mayor:
            mayor = numero

        contador = contador + 1

    print(" ===RESULTADOS===")

    if contador > 0:
        print(f"El mayor número ingresado es: {mayor}")
    else:
        print("No se ingresaron números validos")

def Ejemplo03():
    suma_mayores = 0
    suma_menores = 0
    cont_mayores = 0
    cont_menores = 0

    while True:
        numero = int(input("Ingrese un número (0 para terminar): "))

        if numero == 0:
            break

        if numero > 500:
            suma_mayores = suma_mayores + numero
            cont_mayores = cont_mayores + 1
        elif numero < 500:
            suma_menores = suma_menores + numero
            cont_menores = cont_menores + 1
        
    if cont_mayores > 0:
        prom_mayores = suma_mayores / cont_mayores

    if cont_menores > 0:
        prom_menores = suma_menores / cont_menores

    print ("===RESULTADOS===")
    print(f"Promedio mayores a 500: {prom_mayores:.2f}")
    print(f"Promedio menores a 500: {prom_menores:.2f}")

if __name__ == "__main__":
    #Ejemplo01()
    #Ejemplo02()
    Ejemplo03()