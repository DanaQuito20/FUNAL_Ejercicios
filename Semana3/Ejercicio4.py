import math

num = float(input("Ingrese un número decimal: "))

r2 = math.sqrt(num)
redondo = round(num)
elevar3 = math.pow(num, 3) #num**3
r3 = math.pow(num, 1/3) #num**(1/3)

print(f"\nLa raíz cuadrada es: {r2}\nSu valor redondeado sin decimales es: {redondo}\nEl resultado de elevar al cubo es: {elevar3}\nLa raíz cúbica es: {r3}")