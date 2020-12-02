using System;

namespace ProvaQ04
{
  class Program
  {
    static void Main(string[] args)
    {
      int contador = 0;
      int soma = 0;

      while (contador < 5) {
          soma = soma + 10;
          contador = contador + 1;
      }
      Console.WriteLine(soma);
    }
  }
}
