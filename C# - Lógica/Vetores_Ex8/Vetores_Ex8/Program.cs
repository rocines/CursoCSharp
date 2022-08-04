// See https://aka.ms/new-console-template for more information
using System.Globalization;

int N = int.Parse(Console.ReadLine());

double[] alturas = new double[N];
char [] sexo = new char[N];

double menor = 0.0, maior = 0.0, mediaMulheres = 0.0;
int homens = 0, mulheres = 0;

for (int i = 0; i < N; i++)
{
    string[] vet = Console.ReadLine().Split(' ');
    alturas[i] = double.Parse(vet[0], CultureInfo.InvariantCulture);
    sexo[i] = char.Parse(vet[1]);

    if(alturas[i] > maior)
    {
        maior = alturas[i];
    }
    else if(menor == 0 || alturas[i] < menor)
    {
        menor = alturas[i];
    }

    if(sexo[i] == 'F')
    {
        mediaMulheres += alturas[i];
        mulheres++;
    }
    else
    {
        homens++;
    }
}

mediaMulheres /= mulheres;

Console.WriteLine("Menor altura = " + menor.ToString("F2",CultureInfo.InvariantCulture));
Console.WriteLine("Maior altura = " + maior.ToString("F2",CultureInfo.InvariantCulture));
Console.WriteLine("Media das alturas das mulheres = " + mediaMulheres.ToString("F2",CultureInfo.InvariantCulture));
Console.WriteLine("Numero de homens = " + homens);