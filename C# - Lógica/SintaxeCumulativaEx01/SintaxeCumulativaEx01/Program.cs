// See https://aka.ms/new-console-template for more information
using System.Globalization;

int minutos;
double valor;

minutos = int.Parse(Console.ReadLine());
valor = 50.0;

if (minutos > 100)
{
    valor += (minutos - 100.0) * 2.0;
}

Console.WriteLine("Valor a pagar: R$ " + valor.ToString("F2", CultureInfo.InvariantCulture));

