Console.Write("Digite a base do retângulo: ");
double baseRet = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite a altura do retângulo: ");
double altura = Convert.ToDouble(Console.ReadLine());

double area = baseRet * altura;
double perimetro = 2 * (baseRet + altura);

Console.WriteLine($"Área: {area}");
Console.WriteLine($"Perímetro: {perimetro}");
