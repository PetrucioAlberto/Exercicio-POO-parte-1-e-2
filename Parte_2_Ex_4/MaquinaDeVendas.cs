using Parte_2_Ex_4;
using System.Collections.Generic;
using System;

public class Maquina
{
    private List<Produto> estoque;

    public Maquina()
    {
        estoque = new List<Produto>();
    }

    public void CadastrarProduto(string nome, double preco, int quantidade)
    {
        Produto novoProduto = new Produto(nome, preco, quantidade);
        estoque.Add(novoProduto);
    }

    public Produto SelecionarProduto(string nome)
    {
        foreach (Produto produto in estoque)
        {
            if (produto.Nome == nome)
            {
                return produto;
            }
        }
        return null;
    }

    public bool ComprarProduto(string nome)
    {
        Produto produto = SelecionarProduto(nome);
        if (produto != null && produto.Quantidade > 0)
        {
            produto.Quantidade--;
            return true;
        }
        return false;
    }

    public void ExibirEstoque()
    {
        Console.WriteLine("Produtos disponíveis:");
        foreach (Produto produto in estoque)
        {
            Console.WriteLine($"Nome: {produto.Nome}, Valor: {produto.Preco}, Quantidade: {produto.Quantidade}");
        }
    }
}
