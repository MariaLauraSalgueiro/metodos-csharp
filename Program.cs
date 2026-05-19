//ENTENDENDO MÉTODOS EM C#
/*
COM RETORNO E COM PARÂMETROS
static void Concatenar(string nome, string sobrenome)
{
    string nomeSobrenome = nome + " " + sobrenome;
    return nomeSobrenome;
}
string resultado = Concatenar("Maria", "Salgueiro");
Console.WriteLine(resultado);
Console.WriteLine("Fim!");


SEM RETORNO E SEM PARÂMETROS
static void Concatenar()
{
    Console.WriteLine("Digite o nome:" );
    string nome = Console.ReadLine()!;
    
    Console.WriteLine("Digite o sobrenome:");
    string sobrenome = Console.ReadLine()!;

    string nomeSobrenome = nome + " " + sobrenome;
    Console.WriteLine(nomeSobrenome);
}
Concatenar();
Console.WriteLine("Fim!");


COM RETORNO E SEM PARÂMETROS
static string Concatenar()
{
    Console.WriteLine("Digite o nome:" );
    string nome = Console.ReadLine()!;
    
    Console.WriteLine("Digite o sobrenome:");
    string sobrenome = Console.ReadLine()!;

    string nomeSobrenome = nome + " " + sobrenome;
    return nomeSobrenome;
}
string resultado = Concatenar();
Console.WriteLine(resultado);
Console.WriteLine("Fim!");

*/



//-------------------------------------------------------------------------------------------------------------
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
//----------------------------------------------------------------------------------------------------------
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
    Console.Clear();

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
ExecutarTabuada();/*

----------------------------------------------------------------------------------------------------
ATIVIDADE 03
*/
/*
static void ExibirMenuConversao()
{
    Console.Clear();
    Console.WriteLine("=== CONVERSOR DE TEMPERATURA ===");
    Console.WriteLine("1 - Celsius para Fahrenheit");
    Console.WriteLine("2 - Fahrenheit para Celsius");
    Console.Write("Escolha uma opção: ");
}

static string LerOpcaoConversao()
{
    return Console.ReadLine()!;
}

static double LerTemperatura()
{
    Console.Write("Digite a temperatura: ");
    return double.Parse(Console.ReadLine()!);
}

static double ConverterCelsiusParaFahrenheit(double celsius)
{
    return (celsius * 9 / 5) + 32;
}

static double ConverterFahrenheitParaCelsius(double fahrenheit)
{
    return (fahrenheit - 32) * 5 / 9;
}

static void ExibirResultadoConversao(double resultado, string unidade)
{
    Console.WriteLine();
    Console.WriteLine($"Resultado: {resultado:F2} {unidade}");
}

static void ExecutarConversor()
{
    ExibirMenuConversao();

    string opcao = LerOpcaoConversao();
    double temperatura = LerTemperatura();

    switch (opcao)
    {
        case "1":
            double resultadoFahrenheit = ConverterCelsiusParaFahrenheit(temperatura);
            ExibirResultadoConversao(resultadoFahrenheit, "°F");
            break;

        case "2":
            double resultadoCelsius = ConverterFahrenheitParaCelsius(temperatura);
            ExibirResultadoConversao(resultadoCelsius, "°C");
            break;

        default:
            Console.WriteLine("Opção inválida.");
            break;
    }
}

ExecutarConversor();
*/
//----------------------------------------------------------------------------------------------------------

//ATIVIDADE 04- feita 

/*static string LerNomeCliente()
{
    Console.Write("Digite o nome do cliente: ");
    return Console.ReadLine()!;
}
Console.Write("Digite o valor da compra: ");
double valorCompra = double.Parse(Console.ReadLine()!);

static double CalcularDesconto(double valorCompra)
{
    if (valorCompra >= 200)
    {
        return valorCompra * 0.15;
    }
    else
    {
        return valorCompra * 0.05;
    }
}
static double CalcularValorFinal(double valorCompra, double desconto)
{
    return valorCompra - desconto;
}

static void ExibirResumo(string cliente, double valorCompra, double desconto, double valorFinal)
{
    Console.WriteLine($"Cliente: {cliente}");
    Console.WriteLine($"Valor da compra: R$ {valorCompra:F2}");
    Console.WriteLine($"Desconto: R$ {desconto:F2}");
    Console.WriteLine($"Valor final: R$ {valorFinal:F2}");
}
string cliente = LerNomeCliente();
double desconto = CalcularDesconto(valorCompra);
double valorFinal = CalcularValorFinal(valorCompra, desconto);


ExibirResumo(cliente, valorCompra, desconto, valorFinal);


//----------------------------------------------------------------------------------------------------------
//ATIVIDADE 05- feita
*//*
double numero1;
double numero2;
double resultado = 0;
string opcao;
string continuar = "s";

static void ExibirMenu()
{
    Console.WriteLine("=== CALCULADORA ===");
    Console.WriteLine("+ Soma");
    Console.WriteLine("- Subtração");
    Console.WriteLine("* Multiplicação");
    Console.WriteLine("/ Divisão");
    Console.Write("Escolha uma opção: ");
}
static string LerOpcao()
{
    return Console.ReadLine()!;
}

static double LerNumero1(string mensagem)
{
    Console.Write(mensagem);
    return double.Parse(Console.ReadLine()!);
}

static double LerNumero2(string mensagem)
{
    Console.Write(mensagem);
    return double.Parse(Console.ReadLine()!);
}

static double CalcularOperacao(double numero1, double numero2, string operacao)
{
    double resultado = 0;
    if (operacao == "+")
    {
        resultado = numero1 + numero2;
    }
    else if (operacao == "-")
    {
        resultado = numero1 - numero2;
    }
    else if (operacao == "*")
    {
        resultado = numero1 * numero2;
    }
    else if (operacao == "/")
    {
        resultado = numero1 / numero2;
    }
    return resultado;
}

static void ExibirResumo(string operacao, double numero1, double numero2, double resultado)
{
    Console.WriteLine($"Operação: {operacao}");
    Console.WriteLine($"Número 1: {numero1}");
    Console.WriteLine($"Número 2: {numero2}");
    Console.WriteLine($"Resultado: {resultado}");
}

static void Menu()
{
    string continuar = "s";
    while (continuar == "s" || continuar == "S")
    {
        Console.Clear();
        ExibirMenu();
        string opcao = LerOpcao();
        double numero1 = LerNumero1("Digite o primeiro número: ");
        double numero2 = LerNumero2("Digite o segundo número: ");
        double resultado = CalcularOperacao(numero1, numero2, opcao);
        ExibirResumo(opcao, numero1, numero2, resultado);

        Console.WriteLine();
        Console.Write("Deseja fazer outro cálculo? (s/n): ");
        continuar = Console.ReadLine()!;
    }
    Console.Write("Fim de programa!!");
}
Menu();
*/





