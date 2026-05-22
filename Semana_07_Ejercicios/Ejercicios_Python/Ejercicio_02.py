Clave_correcta = "UPN2026"
max_Intentos = 3
intentos = 0
acceso = False

while True:
    intentos = intentos + 1
    clave = input(f"Intento {intentos}/{max_Intentos} - Clave: ")

    if clave == Clave_correcta:
        acceso = True
        break
    else:
        restantes = max_Intentos - intentos

        if restantes > 0:
            print(f"Clave incorrecta. Quedan {restantes} intentos.")

    if acceso or intentos >= max_Intentos:
        break

if acceso:
    print("Acceso concedido. Bienvenido.")
else:
    print("Cuenta bloqueada. Contacta con el adminitrador.")
