int[] vetor = new int[100];

Random r = new Random();

for(int i = 0; i < vetor.Length; i++){
    vetor[i] = r.Next(100);
}

for(int i = 0; i < vetor.Length; i++){
    Console.Write(vetor[i] + "  ");
}

Array.Sort(vetor);

Console.WriteLine("\n\n");
for(int i = 0; i < vetor.Length; i++){
    Console.Write(vetor[i] + "  ");
}