// 1 - criar um vetor de 100 posições inteiras
// 2 - criar um loop para percorrer todo o vetor
// 3 - preencher cada posição com um valor aleatório
// 4 - imprimir o vetor na tela (sem ordenação)

int[] vetor = new int[100];   // Criando o vetor de X posições inteiras

Random r = new Random();   // Para gerar os valores aleatórios

for(int i = 0; i < vetor.Length; i++){   // Laço de repetição para percorrer cada posição
    vetor[i] = r.Next(100);   // Preenchendo cada posição com um valor aleatório
}

for(int i = 0; i < vetor.Length; i++){   // Laço de repetição para imprimir o vetor completo
    Console.Write(vetor[i] + "  ");   // Imprimindo cada posição do vetor
}

// 1 - percorrer o vetor
// 2 - comparar se posição atual é maior que próx posição
// 3 - se for, trocar as posições

bool troca = false;
do{ 
    troca = false;
    for(int i = 0; i < vetor.Length - 1; i++){   // Laço de repetição percorrendo todo o vetor
        if(vetor[i] > vetor[i + 1]){   // Comparando posição atual com próxima posição
            int aux = vetor[i];       // Se a comparação anterior for verdade;
            vetor[i] = vetor[i + 1];  // Ocorre a;
            vetor[i + 1] = aux;       // Troca.
            troca = true;
        }
    }
}while(troca == true);

// imprimindo vetor totalmente ordenado
Console.WriteLine("\n\n");
for(int i = 0; i < vetor.Length; i++){   
    Console.Write(vetor[i] + "  ");   
}