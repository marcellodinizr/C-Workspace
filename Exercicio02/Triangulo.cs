using System;

namespace Exercicio02
{
  class Triangulo
  {
    public static void Main()
    {
      triangulo(1, 1, 1);
      triangulo(1, 1, 2);
      triangulo(1, 2, 2);
      triangulo(1, 2, 1);
      triangulo(1, 2, 3);
      triangulo(5000, 2, 2);
    }

    public static void triangulo(int a, int b, int c)
    {
      if (a + b >= c && a + c >= b && b + c >= a)
      {
        if (a == b && b == c)
        {
          Console.WriteLine("Triangulo Equilátero" + " (" + a + " " + b + " " + c + ") ");
        }
        else if (a == b || b == c || c == a)
        {
          Console.WriteLine("Triangulo Isósceles" + " (" + a + " " + b + " " + c + ") ");
        }
        else if (a != b && b != c && c != a)
        {
          Console.WriteLine("Triangulo Escaleno" + " (" + a + " " + b + " " + c + ") ");
        }
      }
      else
      {
        Console.WriteLine("Valor Invalido" + " (" + a + " " + b + " " + c + ") ");
      }
    }
  }
}
