// See https://aka.ms/new-console-template for more information
using Construtores;
using System.Globalization;

Console.WriteLine("Entre os dados do produto:");
Console.Write("Nome: ");
string nome = Console.ReadLine();
Console.Write("Preço: ");
double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Quantidade no estoque: ");
int quantidade = int.Parse(Console.ReadLine());

Produto p = new Produto(nome, preco, quantidade);

Console.WriteLine("Dados do produto: " + p);

Console.Write("Digite o número de produto a ser adicionado ao estoque: ");
p.AdicionarProdutos(int.Parse(Console.ReadLine()));

Console.WriteLine("Dados atualizados: " + p);

Console.Write("Digite o número de produto a ser removido do estoque: ");
p.RemoverProdutos(int.Parse(Console.ReadLine()));

Console.WriteLine("Dados atualizados: " + p);