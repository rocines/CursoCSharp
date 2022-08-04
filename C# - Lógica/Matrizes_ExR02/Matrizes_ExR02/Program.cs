// See https://aka.ms/new-console-template for more information
int M, N;

string[] s = Console.ReadLine().Split(' ');

M = int.Parse(s[0]);
N = int.Parse(s[1]);

int[,] A = new int[M, N];
int[] soma = new int[M];

for (int i = 0; i < M; i++)
{
    string[] vet = Console.ReadLine().Split(' ');
    for(int j = 0; j < N; j++)
    {
        A[i, j] = int.Parse(vet[j]);
        soma[i] += A[i, j];
    }
}

foreach(int element in soma)
{
    Console.WriteLine(element);
}





