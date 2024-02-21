using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte_1_Ex_6
{
    internal class Produto
    {
        private string Nome;
        private double Preco;
        private int Quantidade;

        public Produto(string nome, double preco, int quantidade)
        {
            this.Nome = nome;
            this.Preco = preco;
            this.Quantidade = quantidade;
        }

        public double CalcularTotal()
        {
            return Preco * Quantidade;
        }

        public bool Disponibilidade()
        {
            return Quantidade > 0;
        }
    }
}