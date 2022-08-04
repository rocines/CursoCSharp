// See https://aka.ms/new-console-template for more information
using System.Globalization;

int N;
N = int.Parse(Console.ReadLine());
double[] S;
S = new double[N];

string[] vet = Console.ReadLine().Split(' ');

double soma = 0, media = 0;

for (int i = 0; i < N; i++)
{
    S[i] = double.Parse(vet[i], CultureInfo.InvariantCulture);
    soma += S[i];
    if(i == N - 1)
    {
        Console.WriteLine(S[i].ToString("F1", CultureInfo.InvariantCulture));
    }
    else
    {
        Console.Write(S[i].ToString("F1", CultureInfo.InvariantCulture) + " ");
    }
}

media = soma / N;

Console.WriteLine(soma.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));