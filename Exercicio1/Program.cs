Console.Write("Digite um número inteiro: ");

try
{
    int numero = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"Número digitado: {numero}");
    Console.WriteLine($"Dobro do número: {numero * 2}");
}
catch
{
    Console.WriteLine("Entrada inválida.");
}
