using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte_2_Ex_1
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public string Profissao { get; set; }


        public Pessoa(string nome, int idade, string profissao )
        {

            this.Nome = nome;
            this.Idade = idade;
            this.Profissao = profissao;
            
        }


        public double calcularIdade()
        {
            int anoBissexto = Idade / 4;
            return anoBissexto;
        }

        public void ExibirInformaçoes()
        {
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Idade: " + Idade);
            Console.WriteLine("Profissão: " + Profissao);
            Console.WriteLine();

            int anosBissextos = (int)calcularIdade();
            Console.WriteLine("Idade em anos bissextos: " + anosBissextos);
        }




    }
}
