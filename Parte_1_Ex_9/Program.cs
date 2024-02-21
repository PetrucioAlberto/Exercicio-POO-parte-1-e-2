using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte_1_Ex_9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Paciente paciente = new Paciente("Petrucio", 32);

            paciente.AdicionarConsulta("Consulta de rotina /  24/06/2024");
            paciente.AdicionarConsulta("Consulta de emergencia  /  15/04/2024");
            paciente.ExibirConsulta();

            Console.ReadKey();
        }
    }
}
