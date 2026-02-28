// See https://aka.ms/new-console-template for more information
Console.WriteLine("Calculadora");

Console.WriteLine("digite o primeiro numero:");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("digite o segundo numero:");
double num2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("escolha a operação:");
Console.WriteLine("1 - adição");
Console.WriteLine("2 - subtração");
Console.WriteLine("3 - multiplicação");
Console.WriteLine("4 - divisão");
int operacao = Convert.ToInt32(Console.ReadLine());

switch (operacao)
{
    case 1:
      Console.WriteLine($"resultado: {num1 + num2}");
      break;
    case 2:
      Console.WriteLine($"resultado: {num1 - num2}");
      break;
    case 3:
      Console.WriteLine($"resultado: {num1 * num2}");
      break;
    case 4:
      if (num2 !=0)
        Console.WriteLine($"resultado: {num1 / num2}");
      else
        Console.WriteLine("erro: divisão por zero não é permitido");
        break;
    default:
      Console.WriteLine("operação invalida.");
      break;
}