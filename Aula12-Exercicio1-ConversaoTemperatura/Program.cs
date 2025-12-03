//01.Conversão de Temperatura -> Difícil
//    Crie um programa que peça ao usuário uma temperatura em graus Celsius.
//    Converta para Fahrenheit usando a fórmula: F = (Cx9 / 5) + 32
//    Exiba o resultado.

Console.WriteLine("Qual a temperatura em Celsius:");
double tempC = double.Parse(Console.ReadLine());
double tempF = (tempC * 9 / 5) + 32;
Console.WriteLine("A temperatura em Fahrenheit é: " + tempF);