// See https://aka.ms/new-console-template for more information
int N = int.Parse(Console.ReadLine());
int[,] A = new int[N, N];
int negativos=0;

for(int i = 0; i < N; i++)
{
    string[] vet = Console.ReadLine().Split(' ');
    for(int j = 0; j < N; j++)
    {
        A[i, j] = int.Parse(vet[j]);
        if(A[i, j] < 0)
        {
            negativos++;
        }
    }
}
Console.WriteLine("DIAGONAL PRINCIPAL: ");
for(int i = 0; i < N; i++)
{
    if (i == N - 1)
    {
        Console.WriteLine(A[i,i]);
    }
    else
    {
        Console.Write(A[i,i] + " ");
    }
}
Console.WriteLine("QUANTIDADE DE NEGATIVOS = " + negativos);
