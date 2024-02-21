using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte_1_Ex_8
{
    internal class Triangulo
    {

        public double LadoA { get; set; }
        public double LadoB { get; set; }
        public double LadoC { get; set; }


        public Triangulo(double ladoA, double ladoB, double ladoC)
        {
            this.LadoA = ladoA;
            this.LadoB = ladoB;
            this.LadoC = ladoC;
        }


        public bool Verificacao()
        {
            
            return (LadoA + LadoB > LadoC) && (LadoA + LadoC > LadoB) && (LadoB + LadoC > LadoA);

        }

        public double CalcularAreatriangulo()
        {
            double semiPerimetro = (LadoA + LadoB + LadoC) / 2;
            double area = Math.Sqrt(semiPerimetro * (semiPerimetro - LadoA) * (semiPerimetro - LadoB) * (semiPerimetro - LadoC));
            return area;

        }

        public void apresentacao()
        {
            if (Verificacao())
            {
                Console.WriteLine("É um triângulo.");
                Console.WriteLine($"Lado A: {LadoA}, Lado B: {LadoB}, Lado C: {LadoC}");
                Console.WriteLine($"Área do triângulo: {CalcularAreatriangulo()}");
            }
            else
            {
                Console.WriteLine("Nao é um triângulo.");
            }


        }

      

    }
}

