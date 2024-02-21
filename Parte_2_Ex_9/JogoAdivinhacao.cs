using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte_2_Ex_9
{
    public class JogoAdivinhacao
    {
        private int numeroSecreto;
        private bool numeroAdivinhado;

        public JogoAdivinhacao()
        {
            Random random = new Random();
            numeroSecreto = random.Next(1, 10); 
            numeroAdivinhado = false;
        }

        public void Adivinhar(int palpite)
        {
            if (palpite < numeroSecreto)
            {
                Console.WriteLine("O palpite é menor que o numero secreto.");
            }
            else if (palpite > numeroSecreto)
            {
                Console.WriteLine("O palpite é maior que o numero secreto.");
            }
            else
            {
                Console.WriteLine("Parabéns! Você acertou o numero secreto: " + numeroSecreto);
                numeroAdivinhado = true;
            }
        }

        public bool NumeroAdivinhado()
        {
            return numeroAdivinhado;
        }
    }
}
