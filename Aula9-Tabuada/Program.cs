// Faça um programa que receba um número e,
// usando laços de repetição,
// calcule e mostre a tabuada desse número.

Console.WriteLine("Insira um número inteiro:");
string entradaUsuario = Console.ReadLine();

bool valido = int.TryParse(entradaUsuario, out int numero);

if (valido)
{
    for (int contador = 1; contador <= 10; contador++)
    {
        Console.WriteLine(contador + " * " + numero + " = " + (contador * numero));
    }
}
else
{
    Console.WriteLine("O valor inserido não é um número inteiro.");
}
