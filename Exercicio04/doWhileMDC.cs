using System;

namespace Exercicio04
{
  class doWhileMDC
  {
    
    public static void Main()
    {
      int num1, num2;

      Console.WriteLine("Digite o primeiro numero: ");
      num1 = int.Parse(Console.ReadLine());

      Console.WriteLine("Digite o segundo numero: ");
      num2 = int.Parse(Console.ReadLine());

      Console.WriteLine("O Máximo Divisor Comum de "
      + num1 + " e " + num2 + " é: " + mdc(num1, num2));
    }

    public static int mdc(int x, int y)
    {
      int resto;

      do
      {
        resto = x % y;
        x = y;
        y = resto;
      } while (y != 0);
      return x;
    }
  }
}