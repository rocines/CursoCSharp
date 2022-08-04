// See https://aka.ms/new-console-template for more information

int N;
int[] vet;

N = int.Parse(Console.ReadLine());
vet = new int[N];

string[] vet2 = Console.ReadLine().Split(' ');

for (int i = 0; i < N; i++)
{
    vet[i] = int.Parse(vet2[i]);
}

for (int i = 0; i < N; i++)
{
    if (vet[i] < 0)
    {
        Console.WriteLine(vet[i]);
    }
}