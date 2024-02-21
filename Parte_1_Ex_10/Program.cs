using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte_1_Ex_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o tatulo do livro:");
            string titulo = Console.ReadLine();

            Console.WriteLine("Digite o nome do autor:");
            string autor = Console.ReadLine();

            Console.WriteLine("Digite o numero de paginas do livro:");
            int numeroPaginas;

            while (!int.TryParse(Console.ReadLine(), out numeroPaginas) || numeroPaginas <= 0)
            {
                Console.WriteLine("Numero de páginas invalido. Por favor, digite um número valido:");
            }


            Livro livro = new Livro(titulo, autor, numeroPaginas);


            livro.DevolverLivro();
            livro.EmprestarLivro();
            livro.EmprestarLivro();



            Console.ReadKey();

        }
    }
}


