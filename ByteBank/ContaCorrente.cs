using System;

public class ContaCorrente {
    public string titular;
    public int agenciaNum;
    public int contaNum;
    public double saldo;

    public bool Sacar(double valor) {
        if (this.saldo < valor) {
            Console.WriteLine($"Saldo inválido!\nSaldo Atual: {this.saldo}");
            return false;
        }
        else {
            this.saldo -= valor;
            Console.WriteLine($"Saque Realizado!\nSaldo Atual: {this.saldo}");
            return true;
        }
    }

    public void Depositar(double valor) {
        this.saldo += valor;
        Console.WriteLine($"Deposito Realizado!\nSaldo Atual: {this.saldo}");
    }

}