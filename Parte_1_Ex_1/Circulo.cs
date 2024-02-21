using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte_1_Ex_1
{
    internal class Circulo
    {
        public double Raio { get; set; }

        public Circulo(double raio)
        {
            this.Raio = raio;
        }

        public double CalcularArea()
        {
            return Math.Round(Math.PI * Math.Pow(Raio, 2), 2);
        }

        public double CalcularPerimetro()
        {
            return Math.Round(2 * Math.PI * Raio, 2);
        }
    }
}
