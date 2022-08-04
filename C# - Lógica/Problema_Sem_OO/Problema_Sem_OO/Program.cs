// See https://aka.ms/new-console-template for more information
using System.Globalization;

double xA, xB, xC, yA, yB, yC, areaX, areaY, pX, pY;
Console.WriteLine("Entre com as medidas do triangulo X: ");
xA = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
xB = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
xC = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
pX = (xA + xB + xC) / 2.0;
areaX = Math.Sqrt(pX * (pX - xA) * (pX - xB) * (pX - xC));

Console.WriteLine("Entre com as medidas do triangulo Y: ");
yA = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
yB = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
yC = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

pY = (yA + yB + yC) / 2.0;
areaY = Math.Sqrt(pY * (pY - yA) * (pY - yB) * (pY - yC));

Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));
if(areaX > areaY)
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
