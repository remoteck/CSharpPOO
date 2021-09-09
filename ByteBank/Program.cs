using System;

namespace ByteBank {
    class Program {
        static void Main(string[] args) {

            ContaCorrente contaLeona = new ContaCorrente() {
                titular = "Leona",
                agenciaNum = 1,
                contaNum = 1,
                saldo = 1500
            };

            ContaCorrente contaMariana = new ContaCorrente() {
                titular = "Mariana",
                agenciaNum = 2,
                contaNum = 2,
                saldo = 250
            };

            contaLeona.Sacar(78);
            contaLeona.Depositar(500);
            contaLeona.Transferir(500, contaMariana);

            Console.ReadLine();
        }
    }
}