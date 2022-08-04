// See https://aka.ms/new-console-template for more information
using System.Globalization;
using OO_Exercicios_03;

Aluno a = new Aluno();

Console.Write("Nome do aluno: ");
a.Nome = Console.ReadLine();
Console.WriteLine("Digite as três notas do aluno: ");
a.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
a.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);   
a.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("NOTA FINAL = " + a.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));

if(a.Aprovado())
{
    Console.WriteLine("APROVADO");
}
else
{
    Console.WriteLine("REPROVADO");
    Console.WriteLine("FALTARAM " + a.NotaRestante().ToString("F2", CultureInfo.InvariantCulture) + " PONTOS");
}
