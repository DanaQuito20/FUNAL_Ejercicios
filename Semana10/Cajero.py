class cajero:
    def __init__(self, saldoInicial = 1000.00):
        self.saldo = saldoInicial

    def Consultar(self) -> float:
        return self.saldo

    def Depositar(self, deposito: float) -> None:
        self.saldo += deposito
        print("¡Depósito exitoso!")

    def Retirar(self, retiro: float) -> None:
        self.saldo -= retiro
        print("¡Retiro exitoso!")