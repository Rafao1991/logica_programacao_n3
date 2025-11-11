// Definir as constantes
const int DEZOITO = 18;
const int ZERO = 0;

// Escrevendo no console uma string pedindo a idade do usuario
Console.WriteLine("Qual a sua idade?");

// Ler a resposta do usuario
string resposta = Console.ReadLine();

// Tenta transformar a string resposta em um int idade,
// atribui o resultado a uma variavel bool
bool ehValido = int.TryParse(resposta, out int idade);

// Verifica se a tentativa de parse funcionou
if (ehValido)
{
    // Verifica se idade é maior ou igual a 18
    if (idade >= DEZOITO)
    {
        Console.WriteLine("Usuário é maior de idade.");
    }
    // Verifica se a idade é válida
    else if (idade < ZERO)
    {
        Console.WriteLine("Idade inválida");
    }
    // Se for valida e menor que 18
    else
    {
        Console.WriteLine("Usuário é menor de idade");
    }
}
// Case nao tenha funcionado
else
{
    Console.WriteLine("Valor informado não corresponde a um número inteiro");
}
