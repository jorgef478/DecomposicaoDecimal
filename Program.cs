Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("+....Decomposição Decimal....+");
Console.WriteLine();

Console.Write("Digite um número inteiro.: ");
int numerointeiro = Convert.ToInt32(Console.ReadLine());

int restante = numerointeiro;

int unidades = restante % 10;
restante /= 10;

int dezenas = restante % 10;
restante /= 10;

int centenas = restante;

Console.WriteLine($"\nO número {numerointeiro} possui:");
Console.WriteLine($" {unidades,10} unidade(s);");
Console.WriteLine($" {dezenas,10} dezenas(s);");
Console.WriteLine($" {centenas,10} centena(s).");