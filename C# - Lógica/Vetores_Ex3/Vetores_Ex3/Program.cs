// See https://aka.ms/new-console-template for more information

int N = int.Parse(Console.ReadLine());

string[] vetA = Console.ReadLine().Split(' ');
string[] vetB = Console.ReadLine().Split(' ');

int[] A = new int[N];
int[] B = new int[N];
int[] C = new int[N];
for (int i = 0; i < N; i++)
{
    A[i] = int.Parse(vetA[i]);
    B[i] = int.Parse(vetB[i]);
    C[i] = A[i] + B[i];
}

foreach(int elemento in C)
{
    Console.Write(elemento + " ");
}
