using System;

namespace Exercicio03
{
  class whileMDC
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

      while (y != 0)
      {
        resto = x % y;
        x = y;
        y = resto;
      }
      return x;
    }
  }
}