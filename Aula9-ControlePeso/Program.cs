// Faça um programa que receba a idade e o peso de sete pessoas. Calcule e mostre:
// A quantidade de pessoas com mais de 90 quilos;
// A média das idades das sete pessoas;

const int QTD_PESSOAS = 7;

int contadorPessoas90Kg = 0;
int somaIdadePessoas = 0;

string entradaUsuario;

for (int contador = 0; contador < QTD_PESSOAS; contador++)
{
    Console.WriteLine("Insira sua idade:");
    entradaUsuario = Console.ReadLine();
    int.TryParse(entradaUsuario, out int idade);

    Console.WriteLine("Insira seu peso:");
    entradaUsuario = Console.ReadLine();
    int.TryParse(entradaUsuario, out int peso);

    somaIdadePessoas += idade;

    if (peso > 90)
    {
        contadorPessoas90Kg++;
    }
}

Console.WriteLine("A quantidade de pessoas com mais de 90 Kg é: " + contadorPessoas90Kg);
Console.WriteLine("A média das idades é: " + (somaIdadePessoas / QTD_PESSOAS));