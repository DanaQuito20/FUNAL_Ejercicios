try:
    numero = int(input("Ingrese el número de la tabla: "))

    while numero <= 0 or numero > 12:
        numero = int(input("\nError. Ingrese el número de la tabla (1 - 12): "))

    i = 1
    print()

    while i <= 12:
        print(f"{numero} x {i} = {numero * i}")
        i += 1

except ValueError:
    print("Error, solo se permiten números.")