using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte_1_Ex_3
{
    internal class Retangulo
    {

        public int Largura { get; set; }
        public int Altura { get; set; }



        public Retangulo(int altura, int largura)
        {
            this.Altura = altura;
            this.Largura = largura;
        }


        public double CalcularArea()
        {

            return Altura * Largura;
        }

        public double CalcularPerimetro()
        {


            return (Altura * Largura) * 2;
        }
        
    }
}

