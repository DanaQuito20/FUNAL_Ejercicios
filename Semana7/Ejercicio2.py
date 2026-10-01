import random

print("-" * 60)
print("|       ¡Bienvenidos al juego de adivinar el número!       |")
print("|"+"-" * 58+"|")
print("|     1. Usted debe de adivinar el número entre 1 y 20.    |")
print("|2. Se le proporcionará una pista por cada intento erróneo.|")
print("|              3. Solo cuenta con 3 intentos.              |")
print("-" * 60)

intentos = 3
aleatorio = random.randint(1, 20)

while intentos > 0:
    num = int(input(f"\nIntento {intentos}: Ingrese el número a adivinar: "))
    if num == aleatorio:
        print("¡Felicidades, adivinaste el número!")
        break
    else:
        if num < aleatorio: print("El número a adivinar es mayor. Vuelva a intentar.")
        else: print("El número a adivinar es menor. Vuelva a intentar.")
        intentos -= 1

else: print(f"\nSe acabaron tus intentos :(. El número era {aleatorio}.")