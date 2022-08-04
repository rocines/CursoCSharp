// See https://aka.ms/new-console-template for more information
int N = int.Parse(Console.ReadLine());

int[,] A = new int[N,N];
int[] soma = new int[N];

for (int i = 0; i < N; i++)
{
    string[] vet = Console.ReadLine().Split(' ');
    for(int j = 0; j < N; j++)
    {
        A[i,j] = int.Parse(vet[j]);
        soma[i] += A[i,j];
    }
}
foreach(int element in soma)
{
    Console.WriteLine(element);
}