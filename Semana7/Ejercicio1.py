cantP = cantI = 0

while True:
    num = int(input("Ingrese un número (Negativo para finalizar): "))

    if num > 0:
        print("Correcto.\n")
        if num % 2 == 0: cantP += 1
        else: cantI += 1

    else: break

print(f"\nLa cantidad de pares es {cantP} y la cantidad de impares es {cantI}.")