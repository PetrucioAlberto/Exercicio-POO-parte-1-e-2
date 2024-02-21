using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte_1_Ex_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                double saldoInicial = 1000;

                Console.WriteLine("Digite o Nome do titular: ou (-1 para sair)");

                


                string titular = Console.ReadLine();

                if (titular == "-1")
                {
                    break;
                }

                Console.WriteLine("Digite o Numero da Conta:");
                int numeroConta;
                while (!int.TryParse(Console.ReadLine(), out numeroConta))
                {
                    Console.WriteLine("Numero de conta invalido. Digite novamente:");
                }

                ContaBancaria conta = new ContaBancaria(titular, saldoInicial, numeroConta);

                Console.WriteLine("Qual operacao voce deseja fazer? (1) Saque ou (2) Deposito:");
                int input;
                while (!int.TryParse(Console.ReadLine(), out input) || (input != 1 && input != 2))
                {
                    Console.WriteLine("Opcao invalida!! Digite 1 para Saque ou 2 para Deposito:");
                }

                switch (input)
                {
                    case 1:
                        Console.WriteLine("Qual valor do saque?");
                        double valorSaque;
                        while (!double.TryParse(Console.ReadLine(), out valorSaque))
                        {
                            Console.WriteLine("Valor inválido. Digite novamente:");
                        }
                        conta.RealizarSaque(valorSaque);
                        break;
                    case 2:
                        Console.WriteLine("Qual valor do deposito?");
                        double valorDeposito;
                        while (!double.TryParse(Console.ReadLine(), out valorDeposito))
                        {
                            Console.WriteLine("Valor invalido. Digite novamente:");
                        }
                        conta.RealizarDeposito(valorDeposito);
                        break;
                }
            } while (true);
        }
    }
}