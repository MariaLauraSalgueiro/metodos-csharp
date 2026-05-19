/*
Um professor deseja criar um programa para ajudar alunos do ensino fundamental a 
estudar tabuada. O sistema deve permitir que o usuário escolha um número e exibir 
a tabuada de 1 até 10.

//--------------------------------------------------------------------------------------------------------------------------------------------
/*ATIVIDADE 02 - feita
static int LerNumeroTabuada() {} - ok
static void ExibirTabuada(int numero){}ok
static string LerContinuacao() {}ok
static bool DesejaContinuar(string resposta) {}ok
static void ExecutarTabuada() {}
```*/
/*
using System;
static int LerNumeroTabuada()
{
    Console.WriteLine("Digite o numero da tabuada:");
    int numero = int.Parse(Console.ReadLine()!);
    return numero;
}
static void ExibirTabuada(int numero)
{
    Console.WriteLine();
    int contador = 1;

    while (contador <= 10)
    {
        Console.WriteLine($"{numero} x {contador} = {numero * contador}");
        contador++;
    }
}
static string LerContinuacao()
{
    Console.Write("Deseja calcular outra tabuada? (s/n): ");
    string opcao = Console.ReadLine()!;
    return opcao;
}
static bool DesejaContinuar(string resposta)
{
    if (resposta.ToLower() == "s")
    {
        return true;
    }
    else
    {
        return false;
    }
}
static void ExecutarTabuada()
{
    console.Clear();

    int numero = LerNumeroTabuada();

    ExibirTabuada(numero);

    string resposta = LerContinuacao();

    if (DesejaContinuar(resposta))
    {
        ExecutarTabuada();
    }
    else
    {
        Console.WriteLine("Fim de programa!!");
    }
    
}
ExecutarTabuada();
*/
