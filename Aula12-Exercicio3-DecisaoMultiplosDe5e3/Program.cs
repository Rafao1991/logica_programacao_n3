//03.Estrutura de Decisão(if/else) -> Fácil
//    Peça ao usuário um número inteiro.
//    Informe se ele é múltiplo de 3, de 5 ou de ambos.

Console.WriteLine("Insira um numero inteiro:");
int n = int.Parse(Console.ReadLine());

bool multiplo3 = n % 3 == 0;
bool multiplo5 = n % 5 == 0;

if (multiplo3 && multiplo5)
{
    Console.WriteLine("O numero eh multiplo de 3 e 5!");
}
else if (multiplo5)
{
    Console.WriteLine("O numero eh multiplo de 5.");
}
else if (multiplo3)
{
    Console.WriteLine("O numero eh multiplo de 3.");
}
else
{
    Console.WriteLine("O nomero NAO eh multiplo nem de 5, nem de 3...");
}
