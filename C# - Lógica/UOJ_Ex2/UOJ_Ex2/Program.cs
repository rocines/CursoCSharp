// See https://aka.ms/new-console-template for more information
using System.Globalization;

double x1, x2, y1, y2, distancia;

string[] p1 = Console.ReadLine().Split(' ');
string[] p2 = Console.ReadLine().Split(' ');

x1 = double.Parse(p1[0],CultureInfo.InvariantCulture);
x2 = double.Parse(p2[0],CultureInfo.InvariantCulture);
y1 = double.Parse(p1[1],CultureInfo.InvariantCulture);
y2 = double.Parse(p2[1],CultureInfo.InvariantCulture);

distancia = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

Console.WriteLine(distancia.ToString("F4", CultureInfo.InvariantCulture));




