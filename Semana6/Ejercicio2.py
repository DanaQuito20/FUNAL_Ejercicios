sumaP = sumaI = 0

while True:
    numero = int(input("Ingrese un número positivo (0 para salir): "))

    if numero == 0:
        break

    if numero < 0:
        print("\nNúmero inválido. Intente de nuevo.\n")
        continue

    if numero % 2 == 0: sumaP += numero
    else: sumaI += numero

print(f"\nLa suma de pares es de {sumaP} y la suma de impares es de {sumaI}.")