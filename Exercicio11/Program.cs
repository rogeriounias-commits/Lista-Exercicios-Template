Console.Write("Digite o valor do produto: ");
double valorProduto = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o valor pago: ");
double valorPago = Convert.ToDouble(Console.ReadLine());

double troco = valorPago - valorProduto;

Console.WriteLine($"Valor do troco: R$ {troco}");
