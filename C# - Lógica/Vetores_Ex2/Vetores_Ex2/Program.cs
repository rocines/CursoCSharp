// See https://aka.ms/new-console-template for more information

int N;
N = int.Parse(Console.ReadLine());

int[] A = new int[N];
int par = 0;

string[] vet = Console.ReadLine().Split(' '); 

for (int i = 0; i < N; i++)
{
    A[i] = int.Parse(vet[i]);
    if(A[i] % 2 == 0)
    {
        if(i == N - 1)
        {
            Console.WriteLine(A[i]);
        }
        else
        {
            Console.Write(A[i] + " ");
        }
        par++;
    }
}
Console.WriteLine(par);