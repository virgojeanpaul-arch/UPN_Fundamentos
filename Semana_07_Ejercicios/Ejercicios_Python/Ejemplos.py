def Ejemplo():
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

def Ejemplo01():
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

if __name__ == "__main__":
    #Ejemplo()
    Ejemplo01();