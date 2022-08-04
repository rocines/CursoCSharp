// See https://aka.ms/new-console-template for more information
using System.Globalization;
using PrimeirosExercicios_Ex02;

Funcionario x, y;
x = new Funcionario();
y = new Funcionario();

Console.WriteLine("Dados do primeiro funcionário:");
Console.Write("Nome: ");
x.nome = Console.ReadLine();
Console.Write("Salário: ");
x.salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

Console.WriteLine("Dados do segundo funcionário:");
Console.Write("Nome: ");
y.nome = Console.ReadLine();
Console.Write("Salário: ");
y.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double media = (x.salario + y.salario) / 2.0;
Console.WriteLine("Salario médio = " + media.ToString("F2", CultureInfo.InvariantCulture));