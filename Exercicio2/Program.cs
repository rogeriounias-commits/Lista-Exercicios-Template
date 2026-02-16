Console.Write("Digite um número: ");
int numero = Convert.ToInt32(Console.ReadLine());

int antecessor = numero - 1;
int sucessor = numero + 1;

Console.WriteLine($"Antecessor:{antecessor}");
Console.WriteLine($"Sucessor:{sucessor}");
