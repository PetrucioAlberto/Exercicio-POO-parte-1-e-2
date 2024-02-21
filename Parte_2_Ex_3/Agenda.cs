using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte_2_Ex_3
{
    internal class Agenda
    {
        private List<ContatoAgenda> contatoAgenda;

        public Agenda()
        {
            contatoAgenda = new List<ContatoAgenda>();
        }

        public void Adicionar(string nome, string endereco, int telefone, int celular)
        {
            ContatoAgenda novoContato = new ContatoAgenda
            {
                Nome = nome,
                Endereco = endereco,
                Telefone = telefone,
                Celular = celular
            };

            contatoAgenda.Add(novoContato);
        }

        public void Buscar()
        {
            foreach (var contato in contatoAgenda)
            {
                Console.WriteLine($"Nome: {contato.Nome}, Endereço: {contato.Endereco}, Telefone: {contato.Telefone}, Celular: {contato.Celular}");
            }
        }

        public void Remover(string nome)
        {
            ContatoAgenda contato = contatoAgenda.Find(c => c.Nome == nome);
            if (contato != null)
            {
                contatoAgenda.Remove(contato);
                Console.WriteLine($"Contato {nome} removido com sucesso.");
            }
            else
            {
                Console.WriteLine($"Contato {nome} não encontrado.");
            }
        }

        public void Editar(string nome, string novoEndereco, int novoTelefone, int novoCelular)
        {
            ContatoAgenda contato = contatoAgenda.Find(c => c.Nome == nome);
            if (contato != null)
            {
                contato.Endereco = novoEndereco;
                contato.Telefone = novoTelefone;
                contato.Celular = novoCelular;
                Console.WriteLine($"Contato {nome} editado com sucesso.");
            }
            else
            {
                Console.WriteLine($"Contato {nome} não encontrado.");
            }
        }
    }
}