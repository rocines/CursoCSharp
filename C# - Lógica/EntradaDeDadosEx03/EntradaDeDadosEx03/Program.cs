// See https://aka.ms/new-console-template for more information
int N, resto, horas, minuto, segundo;
N = int.Parse(Console.ReadLine());

horas = N / 3600;
resto = N % 3600;
minuto = resto / 60;
segundo = resto % 60;

Console.WriteLine(horas + ":" + minuto + ":" + segundo);