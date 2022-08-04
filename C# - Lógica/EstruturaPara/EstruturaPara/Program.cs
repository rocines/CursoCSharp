// See https://aka.ms/new-console-template for more information
int N, soma,x;

N = int.Parse(Console.ReadLine());
soma = 0;

for (int i = 0; i < N; i++)
{
    x = int.Parse(Console.ReadLine());
    soma += x;
}

Console.WriteLine(soma);