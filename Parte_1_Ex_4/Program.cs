using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte_1_Ex_4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            do
            {

                Console.WriteLine(" Digite o nome do aluno  ou (-1 para sair");
                string nomeAluno = Console.ReadLine();

                if (nomeAluno == "-1")
                {
                    return;
                }


                Console.WriteLine(" Digite o numero de matricula");
                int numeromatricula = int.Parse(Console.ReadLine());

                Console.WriteLine(" Digite a nota sepada por (virgula)");
                string[] stringNotas = Console.ReadLine().Split(',');
                double[] notas = new double[stringNotas.Length];



                for (int i = 0; i < notas.Length; i++)
                {

                    notas[i] = Convert.ToDouble(stringNotas[i]);

                }



                Aluno aluno = new Aluno(nomeAluno, numeromatricula, notas);

                Console.WriteLine($"Media do aluno(a)  {aluno.Nome}: {aluno.Media():F2}");
                aluno.Situaçao();

            } while (true);

           



        }
    }
}
