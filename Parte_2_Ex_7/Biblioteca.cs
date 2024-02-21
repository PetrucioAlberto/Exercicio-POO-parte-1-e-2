using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte_2_Ex_7
{
    class Biblioteca
    {
        private List<Livro> livros;

        public Biblioteca()
        {
            livros = new List<Livro>();
        }

        public void CadastrarLivro(string titulo, string autor)
        {
            Livro novoLivro = new Livro(titulo, autor);
            livros.Add(novoLivro);
            Console.WriteLine($"Livro '{titulo}' cadastrado com sucesso!");
        }

        public void EmprestarLivro(string titulo)
        {
            Livro livro = ProcurarLivro(titulo);
            if (livro != null)
            {
                if (livro.Disponivel)
                {
                    livro.Disponivel = false;
                    Console.WriteLine($"O livro '{titulo}' foi emprestado com sucesso!");
                }
                else
                {
                    Console.WriteLine($"Desculpe, o livro '{titulo}' não está disponível no momento.");
                }
            }
            else
            {
                Console.WriteLine($"O livro '{titulo}' não foi encontrado na biblioteca.");
            }
        }

        public void DevolverLivro(string titulo)
        {
            Livro livro = ProcurarLivro(titulo);
            if (livro != null)
            {
                livro.Disponivel = true;
                Console.WriteLine($"O livro '{titulo}' foi devolvido com sucesso!");
            }
            else
            {
                Console.WriteLine($"O livro '{titulo}' não foi encontrado na biblioteca.");
            }
        }

        public bool VerificarDisponibilidade(string titulo)
        {
            Livro livro = ProcurarLivro(titulo);
            if (livro != null)
            {
                return livro.Disponivel;
            }
            else
            {
                Console.WriteLine($"O livro '{titulo}' não foi encontrado na biblioteca.");
                return false;
            }
        }

        private Livro ProcurarLivro(string titulo)
        {
            foreach (Livro livro in livros)
            {
                if (livro.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase))
                {
                    return livro;
                }
            }
            return null; // Livro não encontrado
        }
    }
}