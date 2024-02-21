using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte_2_Ex_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            JogoAdivinhacao jogo = new JogoAdivinhacao();
            Console.WriteLine("Bem-vindo ao Jogo de Adivinhacao!");

            while (!jogo.NumeroAdivinhado())
            {
                Console.Write("Digite um palpite: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int palpite))
                {
                    jogo.Adivinhar(palpite);
                }
                else
                {
                    Console.WriteLine("Por favor, digite um número valido.");
                }
                Console.ReadKey();
            }
        }
    }
}