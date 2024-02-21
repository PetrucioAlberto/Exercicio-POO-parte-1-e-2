using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte_2_Ex_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LojaVirtual minhaLoja = new LojaVirtual();

            do
            {
                Console.WriteLine("Cadastrar Produto:");
                Console.WriteLine("Insira o nome:");
                string nome = Console.ReadLine();

                Console.WriteLine("Insira o preço:");
                double preco = double.Parse(Console.ReadLine());

                Console.WriteLine("Insira a quantidade:");
                int quantidade = int.Parse(Console.ReadLine());

                Console.WriteLine("Insira o código:");
                int codigo = int.Parse(Console.ReadLine());

                minhaLoja.Cadastrar(nome, preco, quantidade, codigo);

                Console.WriteLine("Produtos cadastrados:");
                minhaLoja.MostrarProdutos();

                Console.WriteLine("Insira o desconto em porcentagem:");
                double desconto = double.Parse(Console.ReadLine());

                double TotalComDesconto = minhaLoja.CalcularTotalComDesconto(desconto);

                Console.WriteLine($"O total a pagar já com desconto é {TotalComDesconto:C}");

            } while (true);
        }
    }
}




