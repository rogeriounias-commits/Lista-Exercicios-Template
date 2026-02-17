Console.Write("Digite o valor por hora: ");
double valorHora = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite as horas trabalhadas no mês: ");
double horas = Convert.ToDouble(Console.ReadLine());

double salario = valorHora * horas;

Console.WriteLine($"Salário mensal: R$ {salario}");

