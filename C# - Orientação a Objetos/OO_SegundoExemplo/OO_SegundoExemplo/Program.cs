// See https://aka.ms/new-console-template for more information
using OO_SegundoExemplo;
using System.Globalization;

Produto produto1 = new Produto();

Console.WriteLine("Entre os dados do produto:");
Console.Write("Nome: ");
produto1.Nome = Console.ReadLine();
Console.Write("Preço: ");
produto1.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Quantidade no estoque: ");
produto1.Quantidade = int.Parse(Console.ReadLine());

Console.WriteLine("Dados do produto: " + produto1);

Console.Write("Digite o número de produto a ser adicionado ao estoque: ");
produto1.AdicionarProdutos(int.Parse(Console.ReadLine()));

Console.WriteLine("Dados atualizados: " + produto1);

Console.Write("Digite o número de produto a ser removido do estoque: ");
produto1.RemoverProdutos(int.Parse(Console.ReadLine()));

Console.WriteLine("Dados atualizados: " + produto1);