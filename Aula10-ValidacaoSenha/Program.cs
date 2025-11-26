// Crie um programa que peça ao usuário uma senha. O programa deve permitir até 3 tentativas.
//
//  A senha correta é "12345".
//  Se o usuário digitar a senha correta E tiver mais de 18 anos (idade informada previamente), o acesso é liberado.
//  Caso contrário, o programa informa que o acesso foi negado.

const string SENHA_CORRETA = "12345";

Console.WriteLine("Insira a sua idade (inteiro):");
bool idadeValida = int.TryParse(Console.ReadLine(), out int idade);

if (!idadeValida)
{
    Console.WriteLine("Idade inválida!");
}
else
{
    int tentativas = 0;
    string senha;

    do
    {
        tentativas++;
        Console.WriteLine("Insira a senha: (tentativa " + tentativas + ")");
        senha = Console.ReadLine();

        if (senha == SENHA_CORRETA && idade >= 18)
        {
            Console.WriteLine("Acesso liberado...");
        }
        else
        {
            Console.WriteLine("Acesso negado...");
        }
    } while (tentativas < 3 && senha != SENHA_CORRETA);
}
