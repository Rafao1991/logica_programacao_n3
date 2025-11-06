//Peça para o usuário inserir dois números inteiros e mostre-os no Console.

int n1;
int n2;

// Escrevi uma mensagem no Console
Console.WriteLine("Insira um numero inteiro: ");
// Li o conteudo de uma linha, quando o usuario apertou a tecla ENTER
// O console só aceita texto (string)
// Logo é preciso converter a string para int
n1 = int.Parse(Console.ReadLine());

// Escrevi outra mensagem no Console
Console.WriteLine("Insira mais um numero inteiro: ");
// Novamente li o conteudo da linha, quando o usuario apertou a tecla ENTER
n2 = int.Parse(Console.ReadLine());

// Mostrar os dois numeros no Console
Console.WriteLine("Voce digitou " + n1 + " e " + n2);

int soma = n1 + n2;
int sub = n1 - n2;

Console.WriteLine("A soma eh: " + soma);
Console.WriteLine("A subtracao eh: " + sub);
