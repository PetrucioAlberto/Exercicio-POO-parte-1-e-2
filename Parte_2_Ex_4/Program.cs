using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte_2_Ex_4
{
    
        public class Program
        {
            public static void Main(string[] args)
            {
                Maquina maquina = new Maquina();
                int opcao;

                do
                {
                    Console.WriteLine("O que você gostaria de fazer ?");
                    Console.WriteLine("1. Cadastrar Produto");
                    Console.WriteLine("2. Selecionar Produto");
                    Console.WriteLine("3. Comprar Produto");
                    Console.WriteLine("4. Exibir Estoque");
                    Console.WriteLine("5. Sair");

                    opcao = Convert.ToInt32(Console.ReadLine());

                    switch (opcao)
                    {
                        case 1:
                            Console.WriteLine("Digite o nome:");
                            string nome = Console.ReadLine();
                            Console.WriteLine("Digite o preco:");
                            double preco = double.Parse(Console.ReadLine());
                            Console.WriteLine("Digite a quantidade:");
                            int quantidade = int.Parse(Console.ReadLine());
                            maquina.CadastrarProduto(nome, preco, quantidade);
                            break;

                        case 2:
                            Console.WriteLine("Digite o nome do produto que voce deseja:");
                            string nomeProduto = Console.ReadLine();
                            Produto produtoSelecionado = maquina.SelecionarProduto(nomeProduto);
                            if (produtoSelecionado != null)
                            {
                                Console.WriteLine($"Produto selecionado: {produtoSelecionado.Nome}, Preço: {produtoSelecionado.Preco}, Quantidade: {produtoSelecionado.Quantidade}");
                            }
                            else
                            {
                                Console.WriteLine("Produto não encontrado.");
                            }
                            break;

                        case 3:
                            Console.WriteLine("Digite o nome do produto que você deseja comprar:");
                            string nomeCompra = Console.ReadLine();
                            if (maquina.ComprarProduto(nomeCompra))
                            {
                                Console.WriteLine($"Produto {nomeCompra} comprado com sucesso.");
                            }
                            else
                            {
                                Console.WriteLine("Produto não encontrado ou estoque esgotado.");
                            }
                            break;

                        case 4:
                            maquina.ExibirEstoque();
                            break;

                        case 5:
                            Console.WriteLine("Saindo...");
                            break;

                        default:
                            Console.WriteLine("Opção inválida. Tente novamente.");
                            break;
                    }
                } while (opcao != 5);
            }
        }
    }
