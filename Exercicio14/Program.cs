int Somar(int a, int b)
{
    return a + b;
}

Console.Write("Digite o primeiro número: ");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o segundo número: ");
int n2 = Convert.ToInt32(Console.ReadLine());

int resultado = Somar(n1, n2);

Console.WriteLine($"Resultado: {resultado}");

