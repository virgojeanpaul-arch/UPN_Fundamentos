subtotal = 0
total_Articulos = 0

while True:
    print("/n === TIENDA TECH ===")
    print("1. USB 32GB - S/.25.00")
    print("2. Mouse inalámbrico - S/.45.00")
    print("3. Audífonos - S/.60.00")
    print("0. Finalizar compra")

    opcion = int(input("Elija una de las opciones (0 - 3): "))

    if opcion >= 1 and opcion <= 3:
        cantidad = int(input("Cantidad: "))
        precio = 0

        if opcion == 1:
            precio = 25

        elif opcion == 2:
            precio = 45

        elif opcion == 3:
            precio = 60
        
        subtotal = subtotal + (precio * cantidad)
        total_Articulos = total_Articulos + cantidad

    elif opcion == 0:
        break

    else:
        print("Opción no válida.")

descuento = 0

if subtotal > 100:
    descuento = subtotal * 0.10

total = subtotal - descuento

print("n/ === RESUMEN ===")
print(f"Artículos: {total_Articulos}")
print(f"Subtotal: S/.{subtotal:.2f}")
print(f"Descuento: S/.{descuento:.2f}")
print(f"TOTAL: S/.{total}")