using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte_2_Ex_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RedeSocial redeSocial = new RedeSocial();

           
            redeSocial.AdicionarAmigo("user1", "user2");
            redeSocial.AdicionarAmigo("user1", "user3");

           
            redeSocial.PublicarMensagem("user1", "Ola, mundo");
            redeSocial.PublicarMensagem("user2", "Como estão?");

           
            redeSocial.ComentarPost("user3", "user1", "Legal");

            
            redeSocial.BuscarUsuario("user1");
            Console.ReadKey();
        }
    }
}