votos_Ana = 0
votos_Carlos = 0
votos_Lucia = 0
votos_nulos = 0

while True:
    print("n/=== SISTEMA DE VOTACIÓN ===")
    print("1. Ana Torres")
    print("2. Carlos Mendoza")
    print("3. Lucía Paredes")
    print("0. Cerrar votación")

    voto = int(input("Ingrese su voto (0 para salir): "))

    if voto == 1:
        votos_Ana += 1

    elif voto == 2:
        votos_Carlos += 1

    elif voto == 3:
        votos_Lucia += 1

    elif voto == 0:
        break

    else:
        nulos += 1
        print("Voto nulo.")

total = votos_Ana + votos_Carlos + votos_Lucia + votos_nulos

print("/n === RESULTADOS ===")
print(f"Votos de ana: {votos_Ana}")
print(f"Votos de Carlos: {votos_Carlos}")
print(f"Votos de Lucía: {votos_Lucia}")
print(f"Votos nulos: {votos_nulos}")
print(f"Total de votantes: {total}")

if votos_Ana > votos_Carlos and votos_Ana > votos_Lucia:
    print("Ganadora: Ana Torres")

elif votos_Carlos > votos_Ana and votos_Carlos > votos_Lucia:
    print("Ganador: Carlos Mendoza")

elif votos_Lucia > votos_Ana and votos_Lucia > votos_Carlos:
    print("Ganadora: Lucía Paredes")

else: 
    print("Resultado: EMPATE")