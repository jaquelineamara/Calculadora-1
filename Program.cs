string operação;



Console.WriteLine("[1] SOMA");
Console.WriteLine("[2] SUBTRAÇÃO ");
Console.WriteLine("[3] MULTIPLICAÇÃO");
Console.WriteLine("[4] DIVISÃO");



Console.Write("\nSELECIONE A OPERAÇÃO DESEJADA: ");
operação = Console.ReadLine()!;



switch (operação)
{
case "1":
CalcularSoma();
break;



case "2":
CalcularSubtração();
break;



case "3":
CalcularMultiplicação();
break;



case "4":
CalcularDivisão();
break;
}



void CalcularSoma()
{
Console.Clear();
double a, b, resultado;

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("\nOperação Soma selecionada.\n");
Console.WriteLine("Digite os valores para somar: ");

Console.Write("");
a = Convert.ToDouble(Console.ReadLine());

Console.Write("");
b = Convert.ToDouble(Console.ReadLine());

resultado = a + b;

Console.WriteLine($"{a} + {b} = {resultado}");

Console.ResetColor();
return;
}



void CalcularSubtração()
{
Console.Clear();
double a, b, resultado;



Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("\nOperação Subtraçao selecionada.\n");
Console.WriteLine("Digite os valores para subtrair: ");



Console.Write("");
a = Convert.ToDouble(Console.ReadLine());



Console.Write("");
b = Convert.ToDouble(Console.ReadLine());



resultado = a - b;



Console.WriteLine($"{a} - {b} = {resultado}");



return;
}



void CalcularMultiplicação()
{
Console.ForegroundColor = ConsoleColor.Magenta;
Console.Clear();
double a, b, resultado;



Console.WriteLine("\nOperação Multiplicação selecionada. \n");
Console.WriteLine("Digite os Valores para Multiplicar:");



Console.Write("");
a = Convert.ToDouble(Console.ReadLine());



Console.Write("");
b = Convert.ToDouble(Console.ReadLine());



resultado = a * b;



Console.WriteLine($"{a} x {b} = {resultado}");



Console.ResetColor();
return;
}



void CalcularDivisão()
{
Console.ForegroundColor = ConsoleColor.Red;
Console.Clear();
double a, b, resultado;



Console.WriteLine("\nOperação Divisão selecionada. \n");
Console.Write("Digite os Valores para Divisão: ");



Console.Write("");
a = Convert.ToDouble(Console.ReadLine());



Console.Write("");
b = Convert.ToDouble(Console.ReadLine());



resultado = a / b;

Console.WriteLine($"{a} ÷ {b} = {resultado}");



Console.ResetColor();
return;



}
