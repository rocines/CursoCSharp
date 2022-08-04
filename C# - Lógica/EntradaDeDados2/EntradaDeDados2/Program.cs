// See https://aka.ms/new-console-template for more information
using System.Globalization;

/* int n1 = int.Parse(Console.ReadLine());
Console.WriteLine("Número salvo na variável n1: " + n1);

char ch = char.Parse(Console.ReadLine());
Console.WriteLine("Caracter salvo na variável ch: " + ch);


double d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine("Número salvo na variável d: " + d.ToString("F2", CultureInfo.InvariantCulture));

string[] dados = Console.ReadLine().Split(' ');
string nome = dados[0];
char sexo = char.Parse(dados[1]);
int idade = int.Parse(dados[2]);
double altura = double.Parse(dados[3]);

Console.WriteLine("Nome: " + nome);
Console.WriteLine("Sexo: " + sexo);
Console.WriteLine("Idade: " + idade);
Console.WriteLine("Altura: " + altura);
*/

Console.WriteLine("Entre com o seu nome completo: ");
string nome = Console.ReadLine();

Console.WriteLine("Quantos quartos tem sua casa?");
int quarto = int.Parse(Console.ReadLine());

Console.WriteLine("Entre com o preço de um produto: ");
double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Entre com o seu último nome, idade e altura (na mesma linha)");
string[] dados = Console.ReadLine().Split(' ');
string ultimoNome = dados[0];
int idade = int.Parse(dados[1]);
double altura = double.Parse(dados[2], CultureInfo.InvariantCulture);

Console.WriteLine(nome);
Console.WriteLine(quarto);
Console.WriteLine(preco.ToString("F2",CultureInfo.InvariantCulture));
Console.WriteLine(ultimoNome);
Console.WriteLine(idade);
Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

Console.ReadLine();