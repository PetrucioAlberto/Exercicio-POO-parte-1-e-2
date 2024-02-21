using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte_1_Ex_2
{
    internal class ContaBancaria
    {
        public string Titular { get; set; }
        public double Saldo { get; private set; }
        public int NumeroConta { get; set; }

        public ContaBancaria(string titular, double saldo, int numeroConta)
        {
            Titular = titular;
            Saldo = saldo;
            NumeroConta = numeroConta;
        }

        public void RealizarDeposito(double valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor do depósito deve ser maior que zero.");
                return;
            }

            Saldo += valor;
            Console.WriteLine($"Deposito de {valor:C} realizado com sucesso, saldo: {Saldo:C}");
        }

        public void RealizarSaque(double valorSaque)
        {
            if (valorSaque <= 0)
            {
                Console.WriteLine("O valor do saque deve ser maior que zero.");
                return;
            }

            if (valorSaque > Saldo)
            {
                Console.WriteLine("Saldo insuficiente para realizar o saque.");
                return;
            }

            Saldo -= valorSaque;
            Console.WriteLine($"Saque de {valorSaque:C} realizado com sucesso. Novo saldo: {Saldo:C}");
        }

        public double ObterSaldo()
        {
            return Saldo;
        }
    }
}