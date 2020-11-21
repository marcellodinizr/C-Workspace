using System;

namespace Exercicio01
{
  class anoBissexto
  {
    public static void Main()
    {

      int ano;
      Console.WriteLine("Digite um ano:");
      ano = int.Parse(Console.ReadLine());

      // Chamando a função na Main
      checkAnoBissexto(ano);
    }

    public static bool checkAnoBissexto(int ano)
    {
      bool anoBissexto = false;
      anoBissexto = (((ano % 4) == 0) && ((ano % 100) != 0) || ((ano % 400) == 0));

      if (ano < 1001)
      {
        Console.WriteLine("Apenas anos maior que 1001");
        return false;
      }
      if (anoBissexto.Equals(true))
      {
        Console.WriteLine("Ano Bissexto");
        return true;
      }
      else
      {
        Console.WriteLine("Não é Bissexto");
        return false;
      }
    }
  }
}
