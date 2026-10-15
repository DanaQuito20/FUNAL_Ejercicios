class rectangulo:
    def __init__(self):
        self.bse = float(input("\nIngrese la base del rectángulo: "))
        self.altura = float(input("Ingrese la altura del rectángulo: "))

    def area(self) -> float:
        return self.bse * self.altura

    def perimetro(self) -> float:
        return (self.bse * 2) + (self.altura * 2)