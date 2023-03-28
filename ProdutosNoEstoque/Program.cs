using System;
using System.Globalization;

namespace ProdutosNoEstoque
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entrada de Dados - Produto
            Console.WriteLine("Digite os dados do produto: ");
            Console.Write("Nome: ");
            string nomeProduto = Console.ReadLine();
            Console.Write("Preço: ");
            double precoProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            int qtdeEstoque = int.Parse(Console.ReadLine());

            //Instância de Objeto
            Produto prod = new Produto(nomeProduto, precoProduto, qtdeEstoque);

            //Saída de Dados - Produto
            Console.WriteLine($"\nDados do produto: {prod}");

            //Entrada de Dados - Add. Produtos
            Console.Write("\nDigite o número de produto(s) a serem adicionado(s) ao estoque: ");
            int qtde = int.Parse(Console.ReadLine());
            prod.AdicionarProduto(qtde);

            //Saída de Dados Atualizada - Produto
            Console.WriteLine($"\nDados atualizados do produto: {prod}");

            //Entrada de Dados - Remover Produtos
            Console.Write("\nDigite o número de produto(s) a serem adicionado(s) ao estoque: ");
            qtde = int.Parse(Console.ReadLine());
            prod.RemoverProduto(qtde);

            //Saída de Dados Atualizada - Produto
            Console.WriteLine($"\nDados atualizados do produto: {prod}");
        }
    }
}
