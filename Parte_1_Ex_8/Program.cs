using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte_1_Ex_8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int ladoA, ladoB, ladoC;

            Console.WriteLine("Digite o valor do lado A do triângulo:");
            while (!int.TryParse(Console.ReadLine(), out ladoA))
            {
                Console.WriteLine("Por favor, insira um número inteiro válido para o lado A:");
            }

            Console.WriteLine("Digite o valor do lado B do triângulo:");
            while (!int.TryParse(Console.ReadLine(), out ladoB))
            {
                Console.WriteLine("Por favor, insira um número inteiro válido para o lado B:");
            }

            Console.WriteLine("Digite o valor do lado C do triângulo:");
            while (!int.TryParse(Console.ReadLine(), out ladoC))
            {
                Console.WriteLine("Por favor, insira um número inteiro válido para o lado C:");
            }

            Triangulo tri = new Triangulo(ladoA, ladoB, ladoC);

            tri.apresentacao();

            Console.ReadKey();
        }
    }
}




