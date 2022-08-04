// See https://aka.ms/new-console-template for more information
using System.Globalization;

int X;
double[] vet;

X = int.Parse(Console.ReadLine());
vet = new double[X];
for (int i = 0; i < X; i++)
{
    vet[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
}

for (int j = 0; j < X; j++)
{
    Console.WriteLine(vet[j].ToString(CultureInfo.InvariantCulture));
}