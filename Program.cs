namespace Projeto_Final_Calculadora
{
class Program
{
static void Main(string[] args)
{
string operação;

do
{
exibeMenu();
operação = Console.ReadLine()!.Trim().ToUpper();

switch (operação)
{
case "1":
calculaSoma();
break;
case "2":
calculaSubtracao();
break;
case "3":
calculaMultiplicacao();
break;
case "4":
calculaDivisao();
break;
case "5":
calculaExponenciacao();
break;
case "6":
calculaRadiciacao();
break;
case "7":
CalcularMDC();
break;
case "8":
CalcularMédiaAritmética();
break;
case "9":
Console.WriteLine("Projeto de encerramento do 1º módulo feito em C#\n user: Jaqueline Amara );
break;
case "0":
Console.WriteLine("\nObrigada por utilizar meu programa :)");
break;
default:
Console.WriteLine("Operação indisponível");
break;
}
Console.WriteLine("\nPressione qualquer tecla para continuar...\n");
Console.ReadKey();
Console.Clear();
}
while (operação != "0");

}

static void exibeMenu()
{

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("------------------------");
Console.WriteLine("¯_¯_      CALCULADORA       ");
Console.WriteLine("------------------------");
Console.WriteLine("    [1] SOMA                ");
Console.WriteLine("    [2] SUBTRAÇÃO           ");
Console.WriteLine("    [3] MULTIPLICAÇÃO       ");
Console.WriteLine("    [4] DIVISÃO             ");
Console.WriteLine("    [5] EXPONENCIAÇÃO       ");
Console.WriteLine("    [6] RADICIAÇÃO          ");
Console.WriteLine("    [7] MAIOR DIVISOR COMUM ");
Console.WriteLine("    [8] MÉDIA ARITMÉTICA    ");
Console.WriteLine("    [9] SOBRE O PROJETO     ");
Console.WriteLine("    [0] SAIR                ");
Console.WriteLine("¯_¯_¯_¯_¯_¯_¯_¯_¯_¯_¯_¯_¯_¯_¯_¯_\n");

Console.ResetColor();
}

static void calculaSoma()
    {
    double a, b, resultado;
    
    Console.WriteLine("\nOperação Soma selecionada.\n");
    Console.WriteLine("Digite os valores para somar: ");
    
    Console.Write("");
    a = Convert.ToDouble(Console.ReadLine());
    
    Console.Write("");
    b = Convert.ToDouble(Console.ReadLine());
    
    resultado = a + b;
    
    Console.WriteLine($"{a} + {b} = {resultado}");
    }

static void calculaSubtracao()
    {
    double a, b, resultado;

    Console.WriteLine("\nOperação Subtraçao selecionada.\n");
    Console.WriteLine("Digite os valores para subtrair: ");

    Console.Write("");
    a = Convert.ToDouble(Console.ReadLine());

    Console.Write("");
    b = Convert.ToDouble(Console.ReadLine());

    resultado = a - b;

    Console.WriteLine($"{a} - {b} = {resultado}");
    }

static void calculaMultiplicacao()
    {
    double a, b, resultado;

    Console.WriteLine("\nOperação Multiplicação selecionada. \n");
    Console.WriteLine("Digite os Valores para Multiplicar:");

    Console.Write("");
    a = Convert.ToDouble(Console.ReadLine());

    Console.Write("");
    b = Convert.ToDouble(Console.ReadLine());

    resultado = a * b;

    Console.WriteLine($"{a} x {b} = {resultado}");
    }

static void calculaDivisao()
    {
    double a, b, resultado;

    Console.WriteLine("\nOperação Divisão selecionada. \n");
    Console.Write("Digite os Valores para Divisão: ");

    Console.Write("");
    a = Convert.ToDouble(Console.ReadLine());

    Console.Write("");
    b = Convert.ToDouble(Console.ReadLine());

    resultado = a / b;
    
    Console.WriteLine($"{a} ÷ {b} = {resultado}");
    }

static void calculaExponenciacao()
    {
    double b, p, resultado;

    Console.WriteLine("\nOperação Exponenciação Selecionada. \n");
    
    Console.Write("Digite a base: ");
    Console.Write("");
    b = Convert.ToDouble(Console.ReadLine());

    Console.Write("Digite a Potência: ");
    Console.Write("");
    p = Convert.ToDouble(Console.ReadLine());

    resultado = Math.Pow(b, p);

    Console.WriteLine($"A potência de {b} elevado a {p} é igual a {resultado:N2}");
    }

static void calculaRadiciacao()
{
     double numero, resultado;
    
     Console.WriteLine("\nOperação Radiciação Selecionada. \n");
     Console.Write("Digite um Número: ");
     Console.Write("");
     numero = Convert.ToDouble(Console.ReadLine());

     if (numero <0)
     {
     Console.WriteLine("Não existem raízes de números negativos!");
     }

     else 
     {
     resultado = Math.Sqrt(numero);
     Console.WriteLine($"A raiz de {numero} é igual a {resultado:N2}");
     }
}

static void CalcularMDC()
{
     Console.WriteLine("\nOperação Maior Divisor Comum Selecionada. \n");

     int a, b, resto;
     Console.Write("Digite o 1ª número: ");
     a = Convert.ToInt32(Console.ReadLine());

     Console.Write("Digite o 2ª número: ");
     b = Convert.ToInt32(Console.ReadLine());

     do
     {
        resto = a % b;
        a = b;
        b = resto;
     }
     while (resto != 0);
     Console.WriteLine($"MDC = {a}");
}

static void CalcularMédiaAritmética()
{
    Console.WriteLine("\nOperação Média Aritmética de 3 números Selecionada \n");

    double n1, n2, n3, media;
    
    Console.Write("Digite o primeiro número: ");
    n1 = Convert.ToDouble(Console.ReadLine())!;
    
    Console.Write("Digite o segundo número: ");
    n2 = Convert.ToDouble(Console.ReadLine())!;
    
    Console.Write("Digite o terceiro número: ");
    n3 = Convert.ToDouble(Console.ReadLine())!;
    
    media = (n1 + n2 + n3) / 3;
    
    Console.WriteLine($"Média: {media:N1}");
}
static double digitaNumero(string mensagem)
{
double numero = 0;
Console.Write(mensagem);
Double.TryParse(Console.ReadLine(), out numero);
return numero;
}

static double digitaNumeroOrdenado(string ordem)
{
return digitaNumero($"Digite o {ordem} número:");
}


}
}
