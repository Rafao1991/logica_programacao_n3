Random random = new Random();
//List<int> numeros = new List<int> { 1, 2, 3, 4, 5 };
List<int> numeros = new();

for (int i = 0; i < random.Next(1, 10001); i++)
{
    numeros.Add(random.Next(1, 101));
}

for (int i = 0; i < numeros.Count; i++)
{
    int numero = numeros[i];
    if (numero % 2 == 0)
    {
        Console.WriteLine(numero);
    }
}