saldo = 1000
retiros = 0

print("=== CAJERO AUTOMÁTICO ===")
print(f"Saldo disponible: S/{saldo:.2f}")

monto = float(input("Monto a retirar (0 para salir): "))

while monto != 0:
    if monto < 0:
        print ("Error: Monto inválido")
    elif monto > saldo:
        print ("Error: Saldo insuficiente")
    else:
        saldo -= monto
        retiros += 1
        print(f"Retiro exitoso. Saldo: S/. {saldo:.2f}")

    monto = float(input("Monto a retirar (0 para salir)"))

print("--- RESUMEN ---")
print(f"Retiros realizados: {retiros}")
print(f"Saldo final: {saldo:.2f}")