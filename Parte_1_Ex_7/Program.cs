using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte_1_Ex_7
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Carro carro = new Carro("Ford", "ford ka");

            //carro.Acelerar(-20);
            //carro.ExibirVelocidade();

            carro.Frear(80);
            carro.ExibirVelocidade();



            Console.ReadKey();


        }
    }
}
