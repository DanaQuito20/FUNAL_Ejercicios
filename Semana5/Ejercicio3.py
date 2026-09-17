numero = int(input("Ingrese un número cualquiera: "))
sumaPares = 0
print("\nLista de números")

for i in range(1, numero + 1):
    print(i)

    if i % 2 == 0:
        sumaPares += i

print(f"\nLa suma de los números pares es de {sumaPares}")