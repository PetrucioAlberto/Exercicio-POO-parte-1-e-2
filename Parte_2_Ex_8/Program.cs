using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte_2_Ex_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calendario calendario = new Calendario();

           
            calendario.ExibirCalendario(2, 2024);

           
            DateTime data = new DateTime(2024, 2, 17);
            Console.WriteLine($"A data {data.ToShortDateString()} é feriado: {calendario.VerificarFeriado(data)}");

            
            DateTime dataInicio = new DateTime(2024, 1, 1);
            DateTime dataFim = new DateTime(2024, 12, 31);
            Console.WriteLine($"Diferença de dias entre {dataInicio.ToShortDateString()} e {dataFim.ToShortDateString()}: {calendario.CalcularDiferencaDias(dataInicio, dataFim)} dias");
            Console.ReadKey();
        }
    }
}