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

            contaLeona.Sacar(78);
            contaLeona.Depositar(500);

            Console.ReadLine();
        }
    }
}