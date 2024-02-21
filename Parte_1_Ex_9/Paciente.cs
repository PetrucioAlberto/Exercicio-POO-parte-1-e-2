using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte_1_Ex_9
{
    internal class Paciente
    {

        public  string Nome { get; set; }
        public int Idade { get; set; }
        public List<string> Historico;


        public Paciente(string Nome, int Idade)
        {
            this.Nome = Nome;
            this.Idade = Idade;
            this.Historico = new List<string>();
        }

        public void AdicionarConsulta(string consulta)
        {
            Historico.Add(consulta);
        }

        public void ExibirConsulta()
        {
            Console.WriteLine($" Historico de {Nome}, {Idade} anos");
            Console.WriteLine();
            foreach (var consulta in Historico)
            {
                Console.WriteLine(consulta);
            }



        }






    }
}



