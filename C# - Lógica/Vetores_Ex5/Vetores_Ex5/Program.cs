// See https://aka.ms/new-console-template for more information
using System.Globalization;

int N = int.Parse(Console.ReadLine());

int[] A = new int[N];
string[] vet = Console.ReadLine().Split(' ');
double media = 0.0;
int Npar = 0;

for(int i = 0; i < N; i++)
{
    A[i] = int.Parse(vet[i]);
    if(A[i] % 2 == 0)
    {
        media += A[i];
        Npar++;
    }
    
}
media /= Npar;
Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));