// See https://aka.ms/new-console-template for more information
using System.Globalization;

int N;
N = int.Parse(Console.ReadLine());

double mediaAltura = 0.0;
double menor16 = 0.0;

for(int i = 0; i < N; i++)
{
    string[] vet = Console.ReadLine().Split(' ');
    int idade = int.Parse(vet[1]);
    double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);

    mediaAltura += altura;
    if (idade < 16)
    {
        menor16++;
    }
}

mediaAltura /= N;
menor16 = menor16 / N * 100.0;

Console.WriteLine("Altura média: " + mediaAltura.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("Pessoas com menos de 16 anos: " + menor16.ToString("F1", CultureInfo.InvariantCulture) + "%");