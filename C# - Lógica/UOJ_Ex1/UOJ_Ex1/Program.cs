// See https://aka.ms/new-console-template for more information
using System.Globalization;

double A, B, area, perimetro, diagonal;

A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

area = A * B;
perimetro = 2 * A + 2 * B;
diagonal = Math.Sqrt(A * A + B * B);

Console.WriteLine("AREA = " + area.ToString("F4", CultureInfo.InvariantCulture));
Console.WriteLine("PERIMETRO = " + perimetro.ToString("F4", CultureInfo.InvariantCulture));
Console.WriteLine("DIAGONAL = " + diagonal.ToString("F4", CultureInfo.InvariantCulture));


