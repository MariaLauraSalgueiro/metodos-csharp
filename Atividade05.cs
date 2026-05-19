/*
Refatore o arquivo Calc.cs, deixe tudo dentro de função, 

Sugestão:
- Crie uma função Menu(){  } , que quando executada chama a função Opção() { }
na última linha do código chame a função Menu();

*/
/*static string LerOperacao()
static double LerNumero1()
static double LerNumero2()
static double CalcularOperacao(double numero1, double numero2, string operacao)
static void ExibirResumo(string operacao, double numero1, double numero2, double resultado)
static void Menu() */


//ATIVIDADE 05- feita
/*    
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
ExcutarMenu();
*/






/*----------------------------------------------------------------------------------------------------------------
while (continuar == "s" || continuar == "S")
    {
        Console.Clear();
        Console.WriteLine("=== CALCULADORA ===");
        Console.WriteLine("+ Soma");
        Console.WriteLine("- Subtração");
        Console.WriteLine("* Multiplicação");
        Console.WriteLine("/ Divisão");
        Console.Write("Escolha uma opção: ");
        opcao = Console.ReadLine()!;

        Console.Write("Digite o primeiro número: ");
        numero1 = double.Parse(Console.ReadLine()!);

        Console.Write("Digite o segundo número: ");
        numero2 = double.Parse(Console.ReadLine()!);

        if (opcao == "+")
        {
            resultado = numero1 + numero2;
            Console.WriteLine($"Resultado da soma: {resultado}");
        }
        else if (opcao == "-")
        {
            resultado = numero1 - numero2;
            Console.WriteLine($"Resultado da subtração: {resultado}");
        }
        else if (opcao == "*")
        {
            resultado = numero1 * numero2;
            Console.WriteLine($"Resultado da multiplicação: {resultado}");
        }
        else if (opcao == "/")
        {
            resultado = numero1 / numero2;
            Console.WriteLine($"Resultado da divisão: {resultado}");
        }
        else
        {
            Console.WriteLine("Opção inválida.");
        }

    Console.WriteLine();
    Console.Write("Deseja fazer outro cálculo? (s/n): ");
    continuar = Console.ReadLine()!;
}

Console.Write("Fim de programa!!");*/

