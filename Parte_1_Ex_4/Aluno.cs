using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte_1_Ex_4
{
    internal class Aluno
    {
        public string Nome { get; set; }
        public int Matricula { get; set; }
        public double[] Notas { get; set; }


        public Aluno(string nome, int matricula, double[] notas )
        {
            this.Nome = nome;
            this.Matricula = matricula;
            this.Notas = notas;
        }


        public double Media()
        {
            double soma = 0;

            foreach(double nota in Notas)
            {
                soma += nota;

            }

            double media = soma / Notas.Length;

            return media;
        }

        public void Situaçao()
        {
            double media = Media();
            if(media >= 7)
            {
                Console.WriteLine(" Aluno aprovado sua  media é  : " + media.ToString("F2"));

            }
            else
            {
                Console.WriteLine(" Aluno Rerovado sua  media é  : " + media.ToString("F2"));
            }

        }












    }
}
