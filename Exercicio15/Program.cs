Console.Write("Digite o nome do produto: ");
string produto = Console.ReadLine();

try
{
    Console.Write("Digite o preço unitário: ");
    double preco = Convert.ToDouble(Console.ReadLine());

    Console.Write("Digite a quantidade: ");
    int quantidade = Convert.ToInt32(Console.ReadLine());

    double total = preco * quantidade;

    Console.WriteLine();
    Console.WriteLine("=== RESUMO DA COMPRA ===");
    Console.WriteLine($"Produto: {produto}");
    Console.WriteLine($"Quantidade: {quantidade}");
    Console.WriteLine($"Total: R$ {total:F2}");
}
catch
{
    Console.WriteLine("Entrada inválida. Digite apenas números para preço e quantidade.");
}

