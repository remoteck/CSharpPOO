using System;

namespace ByteBank {
    public class ContaCorrente {
        public Cliente Titular { get; set; }
        public int AgenciaNum { get; set; }
        public int ContaNum { get; set; }
        private double _saldo;

        public double Saldo {
            get {
                return _saldo;
            }
            set {
                if (value < 0) {
                    return;
                }
                else {
                    _saldo += value;
                }
            }
        }

        public bool Sacar(double valor) {
            if (_saldo < valor) {
                Console.WriteLine($"Saldo inválido!\nSaldo Atual: {this.Saldo}");
                return false;
            }
            else {
                _saldo -= valor;
                Console.WriteLine($"Saque Realizado!\nSaldo Atual: {this.Saldo}");
                return true;
            }
        }

        public void Depositar(double valor) {
            _saldo += valor;
            Console.WriteLine($"Deposito Realizado!\nSaldo Atual: {this.Saldo}");
        }


        public bool Transferir(double valor, ContaCorrente conta) {
            if (_saldo < valor) {
                Console.WriteLine($"Transferência Inválida!\nSaldo Atual: {this.Saldo}");
                return false;
            }
            else {
                _saldo -= valor;
                conta.Depositar(valor);
                Console.WriteLine($"Transferência Realizada para {conta.Titular.Nome}!\nSaldo Atual: {this.Saldo}");
                return true;
            }
        }

    }
}