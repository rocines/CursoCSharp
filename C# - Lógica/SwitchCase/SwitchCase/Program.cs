// See https://aka.ms/new-console-template for more information
int dia;
dia = int.Parse(Console.ReadLine());

switch (dia)
{
    case 1:
        Console.WriteLine("Dia da semana: domingo");
        break;
    case 2:
        Console.WriteLine("Dia da semana: segunda");
        break;
    case 3:
        Console.WriteLine("Dia da semana: terça");
        break;
    case 4:
        Console.WriteLine("Dia da semana: quarta");
        break;
    case 5:
        Console.WriteLine("Dia da semana: quinta");
        break;
    case 6:
        Console.WriteLine("Dia da semana: sexta");
        break;
    case 7:
        Console.WriteLine("Dia da semana: sábado");
        break;
    default:
        Console.WriteLine("Dia inválido");
        break;
}
