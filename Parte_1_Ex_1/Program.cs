using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte_1_Ex_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine(" Digite o raio do círculo (ou -1 para sair):");
                double valorRaio;

                if (!double.TryParse(Console.ReadLine(), out valorRaio))
                {
                    Console.WriteLine("Entrada invalida!! Insira um numero valido.");
                    continue;
                }

                if (valorRaio == -1)
                    break;

                Circulo circulo = new Circulo(valorRaio);

                Console.WriteLine($"Círculo com raio {circulo.Raio}");
                Console.WriteLine($"Área do círculo: {circulo.CalcularArea()}");
                Console.WriteLine($"Perímetro do círculo: {circulo.CalcularPerimetro()}");

            } while (true);
        }
    }
}

