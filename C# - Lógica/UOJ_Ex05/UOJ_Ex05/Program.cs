// See https://aka.ms/new-console-template for more information
using System.Globalization;

int continuar, golInter, golGremio, inter, gremio, empate, jogos;
continuar = 1;
inter = 0;
gremio = 0;
empate = 0;
jogos = 0;

while(continuar == 1)
{
    string[] vet = Console.ReadLine().Split(' ');
    golInter = int.Parse(vet[0]);
    golGremio = int.Parse(vet[1]);

    if(golInter > golGremio)
    {
        inter++;
    }
    else if(golGremio > golInter)
    {
        gremio++;
    }
    else
    {
        empate++;
    }
    jogos++;
    Console.WriteLine("Novo grenal (1-sim 2-nao)");
    continuar = int.Parse(Console.ReadLine());
    while (continuar != 1 && continuar != 2)
    {
        Console.WriteLine("Novo grenal (1-sim 2-nao)");
        continuar = int.Parse(Console.ReadLine());
    }
}
Console.WriteLine(jogos + " grenais");
Console.WriteLine("Inter:" + inter);
Console.WriteLine("Gremio:" + gremio);
Console.WriteLine("Empates:" + empate);
if (inter > gremio)
{
    Console.WriteLine("Inter venceu mais");
}
else if (gremio > inter)
{
    Console.WriteLine("Gremio venceu mais");
}
else
{
    Console.WriteLine("Nao houve vencedor");
}
