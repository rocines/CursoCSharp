// See https://aka.ms/new-console-template for more information
using System.Globalization;

char continuar;
double tempF, tempC;
do
{
    Console.Write("Digite a temperatura em Celsius: ");
    tempC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    tempF = ((9.0 * tempC) / 5.0) + 32;
    Console.WriteLine("Equivalente em Fahrenheit: " + tempF.ToString("F1", CultureInfo.InvariantCulture));
    Console.Write("Deseja repetir (s/n)? ");
    continuar = char.Parse(Console.ReadLine());
}while (continuar == 's');