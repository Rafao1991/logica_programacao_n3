// PALINDROMO
//  - ARARA
//  - KAIAK
//  - OVO

Console.WriteLine("Insira uma palavra:");
string palavra = Console.ReadLine().ToLower();
string palavraInvertida = "";

for (int i = palavra.Length - 1; i >= 0 ; i--)
{
    palavraInvertida += palavra[i];
}

if (palavraInvertida == palavra)
{
    Console.WriteLine("PALINDROMO!");
}
else
{
    Console.WriteLine("É só uma palavra mesmo!");
}