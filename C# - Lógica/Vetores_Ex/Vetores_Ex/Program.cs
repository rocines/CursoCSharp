// See https://aka.ms/new-console-template for more information
using System.Globalization;

int N;
N = int.Parse(Console.ReadLine());

double[] A = new double[N];
double maior = 0.0;
int posicao = 0;

string[] vet = Console.ReadLine().Split(' ');
for (int i = 0; i < N; i++)
{
    A[i] = double.Parse(vet[i], CultureInfo.InvariantCulture);
    if (A[i] > maior)
    {
        maior = A[i];
        posicao = i;
    }
}

Console.WriteLine(maior.ToString("F1",CultureInfo.InvariantCulture));
Console.WriteLine(posicao);