//10.Média de Notas -> Médio
//    Solicite ao usuário 4 notas (armazenadas em uma lista).
//    Calcule a média.
//    Use if/else para informar se o aluno está aprovado (média ≥ 7) ou reprovado.

List<double> notas = new List<double>();

for  (int i = 0; i < 4; i++)
{
    Console.WriteLine("Insira sua nota da prova " + (i + 1) + ":");
    notas.Add(double.Parse(Console.ReadLine()));
}

double somaNotas = 0;

for (int i = 0; i < notas.Count; i++)
{
    somaNotas += notas[i];
}

double media = somaNotas / notas.Count;

if (media >= 7)
{
    Console.WriteLine("Aprovado");
}
else
{
    Console.WriteLine("Reprovado");
}