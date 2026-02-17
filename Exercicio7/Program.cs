try
{
    Console.Write("Digite um número inteiro: ");
    int numero = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"Número digitado: {numero}");
}
catch
{
    Console.WriteLine("Entrada inválida. Digite apenas números.");
}

