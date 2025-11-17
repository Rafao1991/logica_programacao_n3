Console.WriteLine("Inserir o lado de um quadrado.");
bool ehValido = int.TryParse(Console.ReadLine(), out int lado);

if (!ehValido)
{
    Console.WriteLine("O lado informado não é valido.");
}
else
{
    int perimetro = lado * 4;
    int area = lado * lado;

    Console.WriteLine("Parímetro: " + perimetro);
    Console.WriteLine("Área: " + area);

    if (area > 1000)
    {
        Console.WriteLine("É um quadrado grande.");
    }
    else
    {
        Console.WriteLine("É um quadrado pequeno");
    }
}
