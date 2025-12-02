//04.Estrutura de Decisão(switch) -> Fácil
//    Solicite ao usuário um número de 1 a 7.
//    Exiba o dia da semana correspondente (1 = Domingo, 2 = Segunda, etc.).

Console.WriteLine("Informe um numero entre 1 e 7:");
int n = int.Parse(Console.ReadLine());

switch (n)
{
    case 1:
        Console.WriteLine("Domingo");
        break;
    case 2:
        Console.WriteLine("Segunda");
        break;
    case 3:
        Console.WriteLine("Terça");
        break;
    case 4:
        Console.WriteLine("Quarta");
        break;
    case 5:
        Console.WriteLine("Quinta");
        break;
    case 6:
        Console.WriteLine("Sexta");
        break;
    case 7:
        Console.WriteLine("Sábado");
        break;
    default:
        Console.WriteLine("Inválido!");
        break;
}
