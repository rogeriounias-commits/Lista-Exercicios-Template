Console.Write("Digite o primeiro número: ");

try
{
    int n1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Digite o segundo número: ");
    int n2 = Convert.ToInt32(Console.ReadLine());

    int soma = n1 + n2;

    Console.WriteLine($"Resultado: A soma de {n1} e {n2} é {soma}");
}
catch
{
    Console.WriteLine("Entrada inválida. Digite apenas números.");
}


