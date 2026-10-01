opcion = "N"

while opcion != "S":
    i = 1
    suma = 0
    num = int(input("Ingrese un número positivo: "))

    while i <= num:
        suma += i
        i += 1

    print(f"La suma desde 1 hasta {num} es: {suma}")

    opcion = input("\n¿Desea salir? (Presione S): ")
print()