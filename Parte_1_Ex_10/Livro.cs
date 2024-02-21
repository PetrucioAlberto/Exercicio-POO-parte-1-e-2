using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte_1_Ex_10
{
    internal class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int NumeroPaginas { get; set; }
        public bool StatusLivro { get; set; }

        public Livro(string titulo, string autor, int numeroPaginas)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.NumeroPaginas = numeroPaginas;
            this.StatusLivro = true; 
        }

        public void EmprestarLivro()
        {
            if (!StatusLivro)
            {
                Console.WriteLine($"O livro {Titulo} do Autor {Autor} com {NumeroPaginas} paginas");
                Console.WriteLine("EMPRESTADO!!!");
                StatusLivro = true;
            }
            else
            {
                Console.WriteLine($"O livro {Titulo} do Autor {Autor} com {NumeroPaginas} paginas");
                Console.WriteLine("DISPONÍVEL PARA EMPRÉSTIMO!!!");
            }
        }

        public void DevolverLivro()
        {
            Console.WriteLine($"O livro {Titulo} do Autor {Autor} com {NumeroPaginas} paginas");
            Console.WriteLine("DEVOLVIDO!!!");
            StatusLivro = false;
        }

        public void VerificarStatusLivro()
        {
            if (StatusLivro)
            {
                Console.WriteLine($"O livro {Titulo} do Autor {Autor} com {NumeroPaginas} paginas");
                Console.WriteLine("DISPONÍVEL!!!");
            }
            else
            {
                Console.WriteLine($"O livro {Titulo} do Autor {Autor} com {NumeroPaginas} paginas");
                Console.WriteLine("INDISPONÍVEL NO MOMENTO!!!");
            }
        }
    }
}

