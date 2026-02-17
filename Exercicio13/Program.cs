Console.Write("Digite a primeira nota: ");
double n1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite a segunda nota: ");
double n2 = Convert.ToDouble(Console.ReadLine());

double media = (n1 + n2) / 2;

Console.WriteLine($"Média: {media.ToString("F2")}");

