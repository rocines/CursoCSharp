// See https://aka.ms/new-console-template for more information
using MembrosEstaticos_Ex01;
using System.Globalization;

Console.Write("Qual é a cotação do dólar? ");
double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write("Quantos dólares você vai comprar? ");
double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double valorpago = ConversorDeMoeda.Calculo(cotacao, valor);
Console.WriteLine("Valor a ser pago em reais = " + valorpago.ToString("F2", CultureInfo.InvariantCulture));
