// See https://aka.ms/new-console-template for more information
using OO_Exercicios_02;
using System.Globalization;

Funcionario f = new Funcionario();

Console.Write("Nome: ");
f.Nome = Console.ReadLine();
Console.Write("Salário Bruto: ");
f.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Imposto: ");
f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Funcionário: " + f);

Console.Write("Digite a porcentagem para aumentar o salário: ");
double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
f.AumentarSalario(porcent);

Console.WriteLine("Dados atualizados: " + f);