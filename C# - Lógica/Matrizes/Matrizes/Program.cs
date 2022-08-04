// See https://aka.ms/new-console-template for more information

int M, N;

string[] vet = Console.ReadLine().Split(' ');
M = int.Parse(vet[0]);
N = int.Parse(vet[1]);

int[,] A = new int[M, N];

for(int i = 0; i < M; i++)
{
    string[] vet2 = Console.ReadLine().Split(' ');
    for(int j = 0; j < N; j++)
    {
        A[i, j] = int.Parse(vet2[j]);
    }
}

for(int i = 0; i < M; i++)
{
    for(int j = 0; j < N; j++)
    {
        if (j == N - 1)
        {
            Console.WriteLine(A[i, j]);
        }
        else
        {
            Console.Write(A[i, j] + " ");
        }
    }
}



