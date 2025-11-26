// Peça ao usuário um número inteiro positivo.
// O programa deve imprimir todos os números de 1 até esse número.
//  Para cada número, informe se ele é par ou ímpar.
//  Se o número for par e múltiplo de 5 ao mesmo tempo, destaque com a mensagem "Par e múltiplo de 5".

Console.WriteLine("Insira um numero inteiro e positivo:");
bool inteiro = int.TryParse(Console.ReadLine(), out int numero);

if (inteiro && numero > 0)
{
    for (int contador = 1; contador <= numero; contador++)
    {
        bool par = contador % 2 == 0;
        bool multiplu5 = contador % 5 == 0;

        if (par && multiplu5)
        {
            Console.WriteLine(contador + " é par e múltiplo de 5.");
        }
        else if (par && !multiplu5)
        {
            Console.WriteLine(contador + " é par.");
        }
        else
        {
            Console.WriteLine(contador + " é ímpar.");
        }
    }
}
else
{
    Console.WriteLine("O número informado não é válido");
}
