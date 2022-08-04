// See https://aka.ms/new-console-template for more information
using System.Globalization;

double media;

string[] pessoa1 = Console.ReadLine().Split(' ');
string[] pessoa2 = Console.ReadLine().Split(' ');

string nome1 = pessoa1[0];
int idade1 = int.Parse(pessoa1[1]); 
string nome2 = pessoa2[0];
int idade2 = int.Parse(pessoa2[1]);

media = (double)(idade1 + idade2) / 2.0 ;

Console.WriteLine("A idade média de " + nome1 + " e " + nome2 + " é de " + media.ToString("F1", CultureInfo.InvariantCulture) + " anos.");
