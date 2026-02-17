Console.Write("Digite a temperatura em Celsius: ");
double celsius = Convert.ToDouble(Console.ReadLine());

double fahrenheit = (celsius * 9 / 5) + 32;

Console.WriteLine($"Resultado:{celsius}°C equivalem a {fahrenheit}°F.");
