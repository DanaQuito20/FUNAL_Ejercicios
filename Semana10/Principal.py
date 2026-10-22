from Cajero import cajero
c = cajero()

def menu():
    print("=" * 50)
    print("|  ¡Bienvenido al sistema de cajero automático!  |")
    print("-" * 50)
    print("|                Menú de opciones                |")
    print("-" * 50)
    print("|               1. Consultar saldo               |")
    print("|               2. Depositar saldo               |")
    print("|               3. Retirar dinero                |")
    print("|                   0. Salir                     |")
    print("=" * 50)
menu()

while True:
    while True:
        try: opcion = int(input("\nIngrese una opción: "))
        except ValueError: opcion = -1

        if 0 <= opcion <= 3: break
        else: print("Opción no válida. Ingrese un número entre el 0 y 3.")

    match opcion:
        case 0:
            print("\n¡Gracias por usar el cajero automático, vuelva pronto!\n")
            exit()

        case 1: print(f"Su saldo actual es de: S/.{c.Consultar()}")

        case 2:
            while True:
                try:
                    deposito = float(input("\nIngrese la cantidad a depositar: "))
                    if deposito > 0: break
                    else: print("Error. Ingrese un número positivo.")
                except: print("Error. Ingrese solo números.")

            c.Depositar(deposito)

        case 3:
            while True:
                try:
                    retiro = float(input("\nIngrese la cantidad a retirar: "))
                    if retiro > 0 and retiro <= c.Consultar(): break
                    else: print("Error. Ingrese un número positivo o menor al saldo.")
                except: print("Error. Ingrese solo números.")

            c.Retirar(retiro)