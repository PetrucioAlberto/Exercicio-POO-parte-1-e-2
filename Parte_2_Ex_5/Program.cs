using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte_2_Ex_5
{
    internal class Program
    {
        static void Main(string[] args)
        {

           

            
            JogoCartas jogo = new JogoCartas();

            jogo.DistribuirCartas(4);

            jogo.ExibirMaosJogadores();

               

            Console.ReadKey();
        }
    }
}


