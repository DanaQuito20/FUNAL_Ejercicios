from Cuadrado import cuadrado
from Rectangulo import rectangulo

c = cuadrado()

def menu():
    print("=" * 60)
    print("|  ¡Bienvenido al sistema de cálculo de áreas y perímetro!  |")
    print("-" * 60)
    print("|                     Menú de opciones                      |")
    print("-" * 60)
    print("|                        1. Cuadrado                        |")
    print("|                       2. Rectángulo                       |")
    print("|                       3. Triángulo                        |")
    print("|                        4. Trapecio                        |")
    print("|                         0. Salir                          |")
    print("=" * 60)

menu()
while True:
    while True:
        try: opcion = int(input("\nIngrese una opción: "))
        except ValueError: opcion = -1

        if 0 <= opcion <= 4: break
        print("Opción no válida. Ingrese un número entre el 0 y 4.")

    match opcion:
        case 0: exit()
        case 1:
            while True:
                try:
                    l = float(input("\nIngrese el lado del cuadrado: "))
                    if l > 0: break
                    else: print("Error. Ingrese un número positivo.")

                except: print("Error. Ingrese solo número.")

            c.area(l)
            c.perimetro(l)

        case 2:
            r = rectangulo()
            print("\nRectángulo ->")
            print(f"Área del rectángulo: {r.area()}")
            print(f"Perímetro del rectángulo: {r.perimetro()}")

    while True:
        continuar = input("\n¿Desea continuar? (s / n): ").lower().strip()
        if continuar in("s", "n"): break
        else: print("Opción no válida. Ingrese solo 's' o 'n'.")

    if continuar == "n": break