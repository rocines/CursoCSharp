// See https://aka.ms/new-console-template for more information
using AreaTriangulo;
using System.Globalization;

Triangulo x, y;
x = new Triangulo();
y = new Triangulo();

Console.WriteLine("Entre com as medidas do triangulo X: ");
x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double areaX = x.Area();

Console.WriteLine("Entre com as medidas do triangulo Y: ");
y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double areaY = y.Area();

Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));
if (areaX > areaY)
{
    Console.WriteLine("Maior área: X");
}
else if (areaX < areaY)
{
    Console.WriteLine("Maior área: Y");
}
else
{
    Console.WriteLine("Área igual");
}


