using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte_1_Ex_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            do
            {



                Console.WriteLine("Digite a Largura do retangulo ou (-1 para sair )");
                int largura;
                while (!int.TryParse(Console.ReadLine(), out largura))
                {
                    Console.WriteLine("Largura invalida!! Digite um valor novamente:");
                }

                if(largura == -1)
                {
                    break;
                }

                Console.WriteLine("Digite a Altura do retangulo:");
                int altura;
                while (!int.TryParse(Console.ReadLine(), out altura))
                {
                    Console.WriteLine("Altura invalida!!! Digite um valor novamente:");
                }

                Retangulo retangulo = new Retangulo(largura, altura);

                double area = retangulo.CalcularArea();
                double perimetro = retangulo.CalcularPerimetro();

                Console.WriteLine($"As medidas sao: largura {largura} e altura {altura}");
                Console.WriteLine($"A area do retangulo é: {area}");
                Console.WriteLine($"O perímetro do retangulo é: {perimetro}");

            }while (true);
        }
    }
}