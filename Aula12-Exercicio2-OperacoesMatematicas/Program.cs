//02.Operações Matemáticas->Fácil
//    Solicite dois números inteiros ao usuário.
//    Armazene-os em variáveis.
//    Calcule e exiba a soma, subtração, multiplicação e divisão.

Console.WriteLine("Informe um numero inteiro:");
string n1 = Console.ReadLine();
Console.WriteLine("Informe um numero inteiro:");
string n2 = Console.ReadLine();

int soma = int.Parse(n1) + int.Parse(n2);
int sub = int.Parse(n1) - int.Parse(n2);
int mult = int.Parse(n1) * int.Parse(n2);
double div = double.Parse(n1) / double.Parse(n2);

Console.WriteLine(soma);
Console.WriteLine(sub);
Console.WriteLine(mult);
Console.WriteLine(div);
