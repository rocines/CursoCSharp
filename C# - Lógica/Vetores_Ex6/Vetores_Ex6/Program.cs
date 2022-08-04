// See https://aka.ms/new-console-template for more information
int N = int.Parse(Console.ReadLine());
string[] nomes = new string[N];
int[] idades = new int[N];
int maisVelho = 0, posicao = 0;

for(int i = 0; i < N; i++)
{
    string[] vet = Console.ReadLine().Split(' ');
    nomes[i] = vet[0];
    idades[i] = int.Parse(vet[1]);

    if (idades[i] > maisVelho)
    {
        maisVelho = idades[i];
        posicao = i;
    }
}
Console.WriteLine("Pessoa mais velha: " + nomes[posicao]);
Console.ReadLine();