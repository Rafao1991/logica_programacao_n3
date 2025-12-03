//07.Contagem de Vogais -> Difícil
//    Peça ao usuário para digitar uma palavra.
//    Use um laço de repetição para percorrer cada letra.
//    Conte quantas vogais (a, e, i, o, u) existem na palavra.
//    Exiba o total de vogais encontradas.

Console.WriteLine("Escreva uma palavra: ");
string palavra = Console.ReadLine().ToLower();

int totalVogais = 0;

for (int i = 0; i < palavra.Length; i++)
{
    char letra = palavra[i];
    if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u')
    {
        totalVogais++;
    }
}

Console.WriteLine(totalVogais);