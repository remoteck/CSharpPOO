using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank {
    class Program {
        static void Main(string[] args) {

            ContaCorrente contaLeona = new ContaCorrente() {
                titular = "Leona Figueiredo Perroni",
                agenciaNum = 260821,
                contaNum = 1,
                saldo = 1000
            };

            Console.WriteLine($"Titular da Conta: {contaLeona.titular}");
            Console.WriteLine($"Agência: {contaLeona.agenciaNum}");
            Console.WriteLine($"Conta: {contaLeona.contaNum}");
            Console.WriteLine($"Saldo: R${contaLeona.saldo}");

            Console.ReadLine();
        }
    }
}