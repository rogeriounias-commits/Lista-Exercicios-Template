Console.Write("Digite o primeiro número: ");
int numero1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o segundo número: ");
int numero2 = Convert.ToInt32(Console.ReadLine());

int soma = numero1 + numero2;
int subtracao = numero1 - numero2;
int multiplicacao = numero1 * numero2;
int divisao = numero1 / numero2;

Console.WriteLine($"Soma: {soma}");
Console.WriteLine($"Subtração: {subtracao}");
Console.WriteLine($"Multiplicação: {multiplicacao}");
Console.WriteLine($"Divisão inteira: {divisao}");

