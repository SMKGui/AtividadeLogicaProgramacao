﻿//  Crie um programa que permita que o usuário cadastre 5 nomes em um vetor. Após o
// cadastro, o programa deve imprimir na tela os nomes cadastrados em ordem alfabética.
// Utilize um laço for para o cadastro e um método de ordenação de sua preferência (por
// exemplo, bubble sort) para ordenar os nomes.


string[] nomes = new string[5];


for (int i = 0; i < nomes.Length; i++)
{
    Console.Write("Digite o nome: ", i + 1);
    nomes[i] = Console.ReadLine();
}

for (int i = 0; i < nomes.Length - 1; i++)
{
    for (int j = 0; j < nomes.Length - 1 - i; j++)
    {
        if (string.Compare(nomes[j], nomes[j + 1]) > 0)
        {
            string temp = nomes[j];
            nomes[j] = nomes[j + 1];
            nomes[j + 1] = temp;
        }
    }
}

Console.WriteLine("\nNomes em ordem alfabética:");
foreach (string nome in nomes)
{
    Console.WriteLine(nome);
}
