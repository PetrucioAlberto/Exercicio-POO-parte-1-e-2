using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte_2_Ex_5
{
    public class JogoCartas
    {
        private List<string> baralho;
        private List<string>[] maosJogadores;

        public JogoCartas()
        {
            InicializarBaralho();
        }

        private void InicializarBaralho()
        {
            baralho = new List<string>();

        
            for (int i = 0; i <= 9; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    baralho.Add(i.ToString());
                }
            }

           
            string[] especiais = { "Pular", "Inverter", "MaisDois" };
            for (int i = 0; i < especiais.Length; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    baralho.Add(especiais[i]);
                }
            }

            EmbaralharBaralho();
        }

        private void EmbaralharBaralho()
        {
            Random rnd = new Random();
            int n = baralho.Count;
            while (n > 1)
            {
                n--;
                int k = rnd.Next(n + 1);
                string value = baralho[k];
                baralho[k] = baralho[n];
                baralho[n] = value;
            }
        }

        public void DistribuirCartas(int numJogadores)
        {
            maosJogadores = new List<string>[numJogadores];
            for (int i = 0; i < numJogadores; i++)
            {
                maosJogadores[i] = new List<string>();
            }

          
            int cartaAtual = 0;
            while (cartaAtual < baralho.Count)
            {
                for (int jogador = 0; jogador < numJogadores && cartaAtual < baralho.Count; jogador++)
                {
                    maosJogadores[jogador].Add(baralho[cartaAtual]);
                    cartaAtual++;
                }
            }
        }

        public void ExibirMaosJogadores()
        {
            for (int i = 0; i < maosJogadores.Length; i++)
            {
                Console.WriteLine($"Mão do Jogador {i + 1}: {string.Join(" ", maosJogadores[i])}");
            }
        }
    }
}