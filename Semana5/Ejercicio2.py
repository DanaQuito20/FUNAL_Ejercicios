lado1 = int(input("Ingrese el lado 1 del triángulo: "))
lado2 = int(input("Ingrese el lado 2 del triángulo: "))
lado3 = int(input("Ingrese el lado 3 del triángulo: "))
print()

if lado1 == lado2 == lado3: print("El triángulo es equilatero")

elif lado1 == lado2 or lado2 == lado3 or lado1 == lado3: print("El triángulo es isósceles")

else: print("El triángulo es escaleno")