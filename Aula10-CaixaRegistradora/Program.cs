// Simule uma caixa registradora simples.
//  O programa deve pedir o valor de cada produto até que o usuário digite 0 para encerrar.
//  Ao final, mostre o total da compra.
//  Se o total for maior que R$ 100 OU o cliente tiver um cupom de desconto (informado como CUPOM10),
//  aplique 10% de desconto.

const string CUPOM10 = "CUPOM10";
double valor = -1;
double total = 0;

while (valor != 0)
{
    Console.WriteLine("Insira o valor do produto:");
    valor = double.Parse(Console.ReadLine());
    if (valor > 0)
    {
        total += valor;
    }
}

Console.WriteLine("Insira o cupom de desconto:");
string cupom = Console.ReadLine();

if (cupom == CUPOM10 || total > 100)
{
    Console.WriteLine("O valor total com 10% de desconto é R$ " + (total * 0.9));
}
else
{
    Console.WriteLine("O valor total é R$ " + total);
}
