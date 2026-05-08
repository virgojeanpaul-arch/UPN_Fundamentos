stock = 500
Total_Vendido = 0

venta = int(input("Unidades vendidas (0 para salir): "))

while venta != 0:
    if venta < 0:
        print("Error: cantidad no puede ser negativa")
    elif venta > stock:
        print(f"Error: stock insuficiente. Quedan {stock}")
    else:
        stock = stock - venta
        Total_Vendido = Total_Vendido + venta
        print (f"Venta registrada. Stock: {stock}")

    venta = int(input("Unidades vendidad (0 para salir): "))

print(f"Stock restante: {stock}")
print(f"Total vendido: {Total_Vendido}")