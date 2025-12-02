//06.Laço de Repetição(while) -> Fácil
//    Solicite ao usuário um número.
//    Continue pedindo novos números até que ele digite 0.
//    Ao final, mostre quantos números foram digitados.

int contador = 0;
int respostaUsuario = -1;

while (respostaUsuario != 0)
{
    Console.WriteLine("Digitar um nro:");
    respostaUsuario = int.Parse(Console.ReadLine());

    if (respostaUsuario != 0 )
    { 
        contador++;
    }
}

Console.WriteLine(contador);