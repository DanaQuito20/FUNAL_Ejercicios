cantNum = int(input("Ingrese la cantidad de números: "))
cantP = cantC = cantI = 0
print()

for i in range (1, cantNum + 1):
    numeros = int(input(f"Ingrese el número {i}: "))

    if numeros == 0: cantC += 1

    elif numeros % 2 == 0: cantP += 1

    else: cantI += 1

print(f"\nLa cantidad de pares es de {cantP}, la de impares de {cantI} y la de ceros de {cantC}")