using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte_1_Ex_5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(" Digite o nome do funcionario");
            string nome = Console.ReadLine();


            double salario;

            while (true)
            {
                Console.WriteLine(" Digite o salario");

                if (double.TryParse(Console.ReadLine(), out salario) && salario >= 0)
                {
                    break;

                }
                else
                {
                    Console.WriteLine(" Salario inavlido, tente novamente");
                }
                

            }

            

            Console.WriteLine(" Digite o cargo");
            string cargo = Console.ReadLine();


            Funcionario funcionario = new Funcionario(nome, salario, cargo);

            Console.WriteLine();
            Console.WriteLine("Dados do funcionaio");
           
            Console.WriteLine("----------------------------------------");


            Console.WriteLine($"O nome do funcionario é :  {nome}");
            Console.WriteLine($"Seu salario é :  {salario}");
            Console.WriteLine($"Seu cargo é :  {cargo}");

            double SalarioLiquido = funcionario.CalcularSalarioLiquido();

            Console.WriteLine($" Seu salario liquido é : {SalarioLiquido:F2} ");

            Console.ReadKey();








        }
    }
}
