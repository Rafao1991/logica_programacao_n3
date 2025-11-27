// Notas
// duas provas
// media

//int[] notas = new int[2];

//Console.WriteLine("Nota p1:");
//notas[0] = int.Parse(Console.ReadLine());

//Console.WriteLine("Nota p2:");
//notas[1] = int.Parse(Console.ReadLine());

//Console.WriteLine("Nota final: " + ((notas[0] + notas[1]) / 2));

List<int> notas = new List<int>();

Console.WriteLine("Nota p1:");
notas.Add(int.Parse(Console.ReadLine()));

Console.WriteLine("Nota p2:");
notas.Add(int.Parse(Console.ReadLine()));

Console.WriteLine("Nota final: " + ((notas[0] + notas[1]) / 2));

for (int i = 0; i < notas.Count; i++)
{
    Console.WriteLine(notas[i]);
}
