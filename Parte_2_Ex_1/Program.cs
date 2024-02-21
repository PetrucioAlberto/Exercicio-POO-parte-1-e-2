using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Parte_2_Ex_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            do
            {

                Console.WriteLine("Insira o nome :");
                string nome = Console.ReadLine();

                int idade;
                Console.WriteLine("Insira a idade:");
                while (!int.TryParse(Console.ReadLine(), out idade) || idade < 0)
                {
                    Console.WriteLine("Idade inválida! Por favor, insira uma idade válida:");
                }


                Console.WriteLine("Insira a profissão :");
                string profissao = Console.ReadLine();

              

                Pessoa pessoa = new Pessoa(nome, idade, profissao);

                pessoa.ExibirInformaçoes();

                

            } while (true);

           
        }
    }
}