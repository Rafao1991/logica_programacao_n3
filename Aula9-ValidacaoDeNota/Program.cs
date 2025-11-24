// Faça um programa que peça uma nota entre zero e dez.
// Mostre uma mensagem caso o valor seja inválido e,
// continue pedindo até que o usuário informe um valor válido.
bool invalido = true;

while (invalido)
{
    Console.WriteLine("Insira sua nota (ENTRE 0 e 10):");
    string entradaUsuario  = Console.ReadLine();
    bool valido = int.TryParse(entradaUsuario, out int nota);
    
    invalido = !valido || nota < 0 || nota > 10;

    if (invalido)
    {
        Console.WriteLine("Informe uma nota válida");
    }
    else
    {
        Console.WriteLine(nota + " é uma nota válida.");
    }
    Console.WriteLine("---");
}