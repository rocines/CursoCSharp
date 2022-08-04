// See https://aka.ms/new-console-template for more information
using OO_Exercicios_01;
using System.Globalization;

Retangulo r = new Retangulo();

Console.WriteLine("Entre a largura e altura do retângulo: ");
r.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("AREA = " + r.Area().ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("PERÍMETRO = " + r.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("DIAGONAL = " + r.Diagonal().ToString("F2", CultureInfo.InvariantCulture));