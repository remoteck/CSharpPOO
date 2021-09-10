using System;

namespace ByteBank {
    class Program {
        static void Main(string[] args) {

            ContaCorrente contaMariana = new ContaCorrente() {
                Titular = new Cliente() {
                    Nome = "Mariana",
                    Cpf = "425.654.378-38",
                    Profissao = "Dona de casa"
                },
                AgenciaNum = 1,
                ContaNum = 1
            };

            ContaCorrente contaGuilherme = new ContaCorrente() {
                Titular = new Cliente() {
                    Nome = "Guilherme",
                    Cpf = "449.466.648-31",
                    Profissao = "Desenvolvedor .NET"
                },
                AgenciaNum = 2,
                ContaNum = 2
            };

            contaMariana.Saldo = 1500;
            contaGuilherme.Saldo = 800;

            Console.WriteLine(contaGuilherme.Saldo);
            Console.WriteLine(contaMariana.Saldo);
            contaGuilherme.Sacar(78);
            contaGuilherme.Depositar(500);
            contaGuilherme.Transferir(500, contaMariana);

            Console.ReadLine();
        }
    }
}