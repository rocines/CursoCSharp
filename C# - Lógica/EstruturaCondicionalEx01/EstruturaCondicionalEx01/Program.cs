// See https://aka.ms/new-console-template for more information
using System.Globalization;

double nota1, nota2, resultado;

nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);   

resultado = nota1 + nota2;
Console.WriteLine("NOTA FINAL = " + resultado.ToString("F1",CultureInfo.InvariantCulture));

if(resultado < 60.0)
{
    Console.WriteLine("REPROVADO");
}


