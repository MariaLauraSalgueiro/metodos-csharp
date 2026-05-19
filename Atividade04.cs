/*
Console.Write("Digite o nome do cliente: ");
string cliente = Console.ReadLine()!;

Console.Write("Digite o valor da compra: ");
double valorCompra = double.Parse(Console.ReadLine()!);

double desconto = 0;

if (valorCompra >= 200)
{
    desconto = valorCompra * 0.15;
}
else
{
    desconto = valorCompra * 0.05;
}

double valorFinal = valorCompra - desconto;

Console.WriteLine($"Cliente: {cliente}");
Console.WriteLine($"Valor da compra: R$ {valorCompra:F2}");
Console.WriteLine($"Desconto: R$ {desconto:F2}");
Console.WriteLine($"Valor final: R$ {valorFinal:F2}");
-----------------------------------------------------------------------------------------------------------------
*/
//ATIVIDADE 04- feita 
/*
static string LerNomeCliente()
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


ExecutarExibirResumo(cliente, valorCompra, desconto, valorFinal);

*/