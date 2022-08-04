﻿// See https://aka.ms/new-console-template for more information
using System.Globalization;

int N = int.Parse(Console.ReadLine());
string[] nomes = new string[N];
double[] notas1 = new double[N];
double[] notas2 = new double[N];

double media = 0.0;

for(int i = 0; i < N; i++)
{
    string[] vet = Console.ReadLine().Split(' ');
    nomes[i] = vet[0];
    notas1[i] = double.Parse(vet[1],CultureInfo.InvariantCulture);
    notas2[i] = double.Parse(vet[2],CultureInfo.InvariantCulture);
}

Console.WriteLine("Alunos aprovados:");

for(int i = 0; i < N; i++)
{
    media = (notas1[i] + notas2[i]) / 2.0;
    if (media >= 6.0)
    {
        Console.WriteLine(nomes[i]);
    }  
}