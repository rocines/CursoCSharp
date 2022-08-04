// See https://aka.ms/new-console-template for more information
using System.Globalization;

double A, B, C, delta, R1, R2, divisor;

string[] vet = Console.ReadLine().Split(' ');

A = double.Parse(vet[0], CultureInfo.InvariantCulture);
B = double.Parse(vet[1], CultureInfo.InvariantCulture);
C = double.Parse(vet[2], CultureInfo.InvariantCulture);

delta = B * B - 4 * A * C;
divisor = 2.0 * A;

if(delta <= 0 || divisor <= 0)
{
    Console.WriteLine("Impossivel calcular");
}
else
{
    R1 = (-B + Math.Sqrt(delta)) / divisor;
    R2 = (-B - Math.Sqrt(delta)) / divisor;
    Console.WriteLine("R1 = " + R1.ToString("F5", CultureInfo.InvariantCulture));
    Console.WriteLine("R2 = " + R2.ToString("F5", CultureInfo.InvariantCulture));
}








