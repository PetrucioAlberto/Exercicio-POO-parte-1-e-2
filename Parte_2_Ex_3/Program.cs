using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte_2_Ex_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Agenda agenda = new Agenda();

            int opcao;

            do
            {
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1. Adicionar contato");
                Console.WriteLine("2. Buscar contatos");
                Console.WriteLine("3. Editar contato");
                Console.WriteLine("4. Remover contato");
                Console.WriteLine("5. Sair do programa");

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Digite o nome:");
                        string nomeAdicionar = Console.ReadLine();
                        Console.WriteLine("Digite o endereço:");
                        string enderecoAdicionar = Console.ReadLine();
                        Console.WriteLine("Digite o telefone residencial:");
                        int telefoneResidencialAdicionar = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o telefone celular:");
                        int telefoneCelularAdicionar = int.Parse(Console.ReadLine());
                        agenda.Adicionar(nomeAdicionar, enderecoAdicionar, telefoneCelularAdicionar, telefoneResidencialAdicionar);
                        break;
                    case 2:
                        Console.WriteLine("Todos os Contatos:");
                        agenda.Buscar();
                        break;
                    case 3:
                        Console.WriteLine("Digite o nome do contato a ser editado:");
                        string nomeEditar = Console.ReadLine();
                        Console.WriteLine("Digite o novo endereço:");
                        string novoEndereco = Console.ReadLine();
                        Console.WriteLine("Digite o novo telefone residencial:");
                        int novoTelefoneResidencial = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o novo telefone celular:");
                        int novoTelefoneCelular = int.Parse(Console.ReadLine());
                        agenda.Editar(nomeEditar, novoEndereco, novoTelefoneCelular, novoTelefoneResidencial);
                        break;
                    case 4:
                        Console.WriteLine("Digite o nome do contato a ser removido:");
                        string nomeRemover = Console.ReadLine();
                        agenda.Remover(nomeRemover);
                        break;
                    case 5:
                        Console.WriteLine("Encerrando o programa...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
                Console.Clear(); 
            } while (opcao != 5);
        }
    }
}