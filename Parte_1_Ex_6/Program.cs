using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte_1_Ex_6
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Digite o nome do produto:");
            string nomeProduto = Console.ReadLine();

            Console.WriteLine("Digite o preço do produto:");
            double precoProduto =  double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade do produto:");
            int quantidadeProduto = int.Parse(Console.ReadLine());

            Produto produto = new Produto(nomeProduto, precoProduto, quantidadeProduto);

            double valorTotal = produto.CalcularTotal();
            Console.WriteLine($"O valor total em estoque do produto é : {valorTotal:F2}");

            bool disponivel = produto.Disponibilidade();

            if (disponivel)
            {
                Console.WriteLine($"O produto {nomeProduto} está disponível em estoque.");
            }
            else
            {
                Console.WriteLine($"O produto {nomeProduto} não está disponível em estoque.");
            }

            Console.ReadLine();


        }
    }
}
