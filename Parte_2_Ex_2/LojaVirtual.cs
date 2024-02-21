using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte_2_Ex_2
{
    internal class LojaVirtual
    {

        List<Produto1> produtos;


        public LojaVirtual()
        {

            produtos = new List<Produto1>();



        }

        public void Cadastrar(string nome, double preco, int codigo, int quantidade)
        {
            Produto1 produto = new Produto1
            {
                Nome = nome,
                Preco = preco,
                Codigo = codigo,
                Quantidade = quantidade

            };

            produtos.Add(produto);

        }

        public void MostrarProdutos()
        {

            foreach (var produto in produtos)
            {
                Console.WriteLine($"Nome: {produto.Nome}, Preço: {produto.Preco}, Código: {produto.Codigo}, Quantidade: {produto.Quantidade}");

            }




        }




        public double CalcularTotalComDesconto(double desconto)
        {
            double total = 0;

            foreach (var produto in produtos)
            {
                total += produto.Preco * produto.Quantidade;
            }

            double totalComDesconto = total - (total * desconto / 100);

            return totalComDesconto;
        }
    }
}





