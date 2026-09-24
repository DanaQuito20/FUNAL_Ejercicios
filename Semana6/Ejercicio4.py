password = "oliuwu123"
intentos = 3

while intentos > 0:
    contraseña = input(f"Intento {intentos}: Ingrese la contraseña: ")

    if password == contraseña:
        print("Acceso concedido.")
        break

    else:
        print("Contraseña incorrecta.\n")
        intentos -= 1

if intentos == 0: print("Sin intentos. Acceso denegado.")