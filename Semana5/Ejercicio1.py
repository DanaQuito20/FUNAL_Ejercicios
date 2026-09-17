edad = int(input("Ingrese su edad: "))
print()
if edad < 18: print("No es elegible para votar ni ser candidato.")
else:
    print("Si puede votar.")

    if edad < 25: print("No puede tener un cargo político.")
    else: print("También puede tener un cargo político.")