// See https://aka.ms/new-console-template for more information
using System.Globalization;

int dia1, dia2, hora1, minuto1, segundo1, hora2, minuto2, segundo2, diferenca, inicio, fim, W, X, Y, Z;

Console.Write("Dia ");
dia1 = int.Parse(Console.ReadLine());
string[] vet = Console.ReadLine().Split(' ');
hora1 = int.Parse(vet[0]);
minuto1 = int.Parse(vet[2]);
segundo1 = int.Parse(vet[4]);

inicio = dia1 * 86400 + hora1 * 3600 + minuto1 * 60 + segundo1;

Console.Write("Dia ");
dia2 = int.Parse(Console.ReadLine());
string[] vet2 = Console.ReadLine().Split(' ');
hora2 = int.Parse(vet2[0]);
minuto2 = int.Parse(vet2[2]);
segundo2 = int.Parse(vet2[4]);

fim = dia2 * 86400 + hora2 * 3600 + minuto2 * 60 + segundo2;

diferenca = fim - inicio;

W = diferenca / 86400;
diferenca = diferenca % 86400;
Console.WriteLine(W + " dia(s)");

X = diferenca / 3600;
diferenca = diferenca % 3600;
Console.WriteLine(X + " hora(s)");

Y = diferenca / 60;
diferenca = diferenca % 60;
Console.WriteLine(Y + " minuto(s)");

Z = diferenca;
Console.WriteLine(Z + " segundo(s)");


