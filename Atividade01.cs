/*
Uma escola deseja criar um pequeno programa para calcular a média final de um aluno. 
O sistema deve receber o nome do aluno e três notas. Ao final, deve exibir a média e 
informar se o aluno foi aprovado, ficou em recuperação ou foi reprovado.

Código iniciado, o método LerNota ( ) é chamado, ele leva a string como mensagem 9Nota 1:; Nota 2: ...
*/

//ATIVIDADE 01 - feita
/*

using System.IO.Pipelines;
using System.Net.Http.Headers;
using System.Reflection;

static string LerNomeAluno()
{
    Console.WriteLine("Digite o nome do aluno:");
    string nome = Console.ReadLine()!;
    return nome;
}

static double LerNota(string mensagem)
{
    Console.Write(mensagem);
    double nota = double.Parse(Console.ReadLine()!);

    return nota;
}
static double CalcularMedia(double nota1, double nota2, double nota3)
{
    double media = (nota1 + nota2 + nota3) / 3;
    return media;
}

static string VerificarSituacao(double media)
{
    if (media >= 7)
    {
        return "Aprovado!";
    }
    else if (media >= 5 && media < 7)
    {
        return "Em recuperação!";

    }
    else
    {
        return "Reprovado!";
    }
}
static void ExibirResultado(string nome, double media, string situacao)
{
    Console.WriteLine($"Aluno: {nome}");
    Console.WriteLine($"Media final: {media}");
    Console.WriteLine($"Situação: {situacao}");
}

static void ExecutarSistema()
{
    string nome = LerNomeAluno();

    double nota1 = LerNota("Nota 1: ");
    double nota2 = LerNota("Nota 2: ");
    double nota3 = LerNota("Nota 3: ");

    double media = CalcularMedia(nota1, nota2, nota3);

    string situacao = VerificarSituacao(media);

    ExibirResultado(nome, media, situacao);
}

ExecutarSistema();
*/

