columnas = int(input("Ingrese la cantidad de columnas: "))
filas = int(input("Ingrese la cantidad de filas: "))
print()

i = 0
while i < filas:
    j = 0
    while j < columnas:
        print("*", end = " ")
        j += 1
    print()
    i += 1