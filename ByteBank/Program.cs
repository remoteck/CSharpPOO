using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank {
    class Program {
        static void Main(string[] args) {

            ContaCorrente contaLeona = new ContaCorrente();

            contaLeona.titular = "Leona Figueiredo Perroni";
            contaLeona.agenciaNum = 260821;
            contaLeona.contaNum = 1;
            contaLeona.saldo = 1000;

            Console.WriteLine($"Titular da Conta: {contaLeona.titular}");
            Console.WriteLine($"Agência: {contaLeona.agenciaNum}");
            Console.WriteLine($"Conta: {contaLeona.contaNum}");
            Console.WriteLine($"Saldo: R${contaLeona.saldo}");

            Console.ReadLine();
        }
    }
}
