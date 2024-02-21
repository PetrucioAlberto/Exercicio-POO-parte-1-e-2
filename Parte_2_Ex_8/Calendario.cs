using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte_2_Ex_8
{
    public class Calendario
    {
        
        public void ExibirCalendario(int mes, int ano)
        {
            int diasNoMes = DateTime.DaysInMonth(ano, mes);
            DateTime primeiroDiaDoMes = new DateTime(ano, mes, 1);
            DayOfWeek diaDaSemanaDoPrimeiroDia = primeiroDiaDoMes.DayOfWeek;

            Console.WriteLine($"Calendário para {mes}/{ano}:");
            Console.WriteLine("Dom Seg Ter Qua Qui Sex Sab");

           
            for (int i = 0; i < (int)diaDaSemanaDoPrimeiroDia; i++)
            {
                Console.Write("    ");
            }

           
            for (int dia = 1; dia <= diasNoMes; dia++)
            {
                Console.Write($"{dia,3}");

                if (diaDaSemanaDoPrimeiroDia == DayOfWeek.Saturday)
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.Write(" ");
                }

                diaDaSemanaDoPrimeiroDia = diaDaSemanaDoPrimeiroDia == DayOfWeek.Saturday ? DayOfWeek.Sunday : diaDaSemanaDoPrimeiroDia + 1;
            }
        }

        
        public bool VerificarFeriado(DateTime data)
        {
           
            return data.DayOfWeek == DayOfWeek.Saturday || data.DayOfWeek == DayOfWeek.Sunday;
        }

        
        public int CalcularDiferencaDias(DateTime dataInicio, DateTime dataFim)
        {
            TimeSpan diferenca = dataFim - dataInicio;
            return diferenca.Days;
        }
    }
}
