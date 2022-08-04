// See https://aka.ms/new-console-template for more information
using System.Globalization;

int N = int.Parse(Console.ReadLine());
double media = 0.0;
double[] A = new double[N];
string[] vet = Console.ReadLine().Split(' ');

for(int i = 0; i < N; i++)
{
    A[i] = double.Parse(vet[i],CultureInfo.InvariantCulture);
    media += A[i];
}

media /= N;
Console.WriteLine(media.ToString("F3", CultureInfo.InvariantCulture));

for(int i = 0; i < N; i++)
{
    if (A[i] < media)
    {
        Console.WriteLine(A[i].ToString("F1",CultureInfo.InvariantCulture));
    }
}