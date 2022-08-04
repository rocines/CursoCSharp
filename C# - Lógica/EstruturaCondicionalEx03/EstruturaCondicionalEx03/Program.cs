// See https://aka.ms/new-console-template for more information
int A, B, C, menor;

string[] vet = Console.ReadLine().Split(' ');

A = int.Parse(vet[0]);
B = int.Parse(vet[1]);
C = int.Parse(vet[2]);

if(A < B && A < C)
{
    Console.WriteLine("MENOR = " + A);
}
else if(B < C){
    Console.WriteLine("MENOR = " + B);
}
else Console.WriteLine("MENOR = " + C);
