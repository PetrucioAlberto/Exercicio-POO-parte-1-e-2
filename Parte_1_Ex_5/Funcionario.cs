using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte_1_Ex_5
{
    internal class Funcionario
    {
        public string Nome { get; set; }
        public double Salario { get; set; }
        public string Cargo { get; set; }


        public Funcionario(string nome, double salario, string cargo)
        {
            this.Nome = nome;
            this.Salario = salario;
            this.Cargo = cargo;
        }

        public double CalcularSalarioLiquido()
        {
            double desconto = 0.12 * Salario;
            double beneficio = 280;
            double SalarioLiquido = Salario - desconto + beneficio;

            return SalarioLiquido;
           
        }



    }
}
