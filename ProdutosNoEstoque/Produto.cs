using System;
using System.Globalization;

namespace ProdutosNoEstoque
{
    class Produto
    {
        //Atributos - Produto
        public string Nome;
        public double Preco;
        public int Quantidade;

        //Construtor
        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        //Função - Valor Total
        public double ValorTotal()
        {
            return Preco * Quantidade;
        }

        //Função - Adicionar Produto
        public void AdicionarProduto(int quantidade)
        {
            Quantidade += quantidade;
        }

        //Função - Remover Produto
        public void RemoverProduto(int quantidade)
        {
            Quantidade -= quantidade;
        }

        //ToString
        public override string ToString()
        {
            return Nome + ", R$ " + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + Quantidade + " unidade(s), Total R$: " + ValorTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
