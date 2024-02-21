using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte_1_Ex_7
{
    internal class Carro
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public double VelocidadeAtual;

        public Carro(string marca, string modelo )
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.VelocidadeAtual = 100;
        }

        public void Acelerar(double Acelerando )
        {
            double velocidadeAntes = VelocidadeAtual;            
            VelocidadeAtual += Acelerando;

            if(VelocidadeAtual > velocidadeAntes)
            {
                Console.WriteLine(" O carro esta Acelerando");
            }
            else
            {
                Console.WriteLine(" O carro esta Freando");
            }
            
        }

        public void Frear(double Freando)
        {

            double velocidadeAntes = VelocidadeAtual;
            VelocidadeAtual -= Freando;

            if(VelocidadeAtual < velocidadeAntes)
            {
                Console.WriteLine(" O carro esta Freando");
            }
            else
            {
                Console.WriteLine(" O carro esta Acelerando");
            }

        }

        public void ExibirVelocidade()
        {
           

            Console.WriteLine($"O carro é da marca {Marca},  modelo:  {Modelo}, sua velocidade  final é {VelocidadeAtual} km/h");
            
        }
    }
}