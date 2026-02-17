try
{
    int n1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Digite o segundo número: ");
    int n2 = Convert.ToInt32(Console.ReadLine());

    int divisao = n1 / n2;

    Console.WriteLine($"Resultado: {n1} ÷ {n2} = {divisao}");
}
catch (FormatException)
{
    Console.WriteLine("Entrada inválida. Digite apenas números.");
}
catch (DivideByZeroException)
{
    Console.WriteLine("Erro: não é possível dividir por zero.");
}

