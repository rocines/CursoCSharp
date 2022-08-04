// See https://aka.ms/new-console-template for more information
using System.Globalization;

Console.WriteLine("Insira a largura do terreno:");
double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Insira o comprimento do terreno:");
double comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Insira o valor do metro quadrado:");
double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double area = largura * comprimento;
Console.WriteLine("AREA = " + area.ToString("F2", CultureInfo.InvariantCulture));

double preco = area * valor;
Console.WriteLine("PREÇO = " + preco.ToString("F2", CultureInfo.InvariantCulture));

Console.ReadLine();