using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte_2_Ex_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca();

            biblioteca.CadastrarLivro("bla", "kkkkk");
            

            biblioteca.EmprestarLivro("bla");
            biblioteca.DevolverLivro("bla");

            bool disponivel = biblioteca.VerificarDisponibilidade("bla");
            Console.WriteLine($"O livro 'bla' está disponível na biblioteca: {disponivel}");

            Console.ReadKey();
        }
    }
}