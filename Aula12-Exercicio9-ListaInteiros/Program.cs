//09.Lista com Inteiros -> Médio
//    Crie uma lista de números inteiros.
//    Peça ao usuário para digitar 5 números e armazene-os na lista.
//    Exiba o maior e o menor número digitado.

List<int> numeros = new List<int>();

for  (int i = 0; i < 5; i++)
{
    Console.WriteLine("Insira um numero inteiro:");
    int numero = int.Parse(Console.ReadLine());

    numeros.Add(numero);
}

int maior = int.MinValue;
int menor = int.MaxValue;

for (int i = 0; i < numeros.Count; i++)
{
    if (numeros[i] > maior)
    {
        maior = numeros[i];
    }

    if (numeros[i] < menor)
    {
        menor = numeros[i];
    }
}

Console.WriteLine("O maior numero eh: " + maior);
Console.WriteLine("O menor numero eh: " + menor);