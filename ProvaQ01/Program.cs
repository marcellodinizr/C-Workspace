using System;

namespace ProvaQ01
{
  class Program
  {
    static void Main(string[] args)
    {
      int x = 28, y = 40;
      metodoXY(x, ref y);
      Console.WriteLine("x = " + x + " y = " + y);
    }

    private static void metodoXY(int x, ref int y) {
      int r;
      r = y % x;
      x = y;
      y = r;
    }
  }
}
// x = 28 , y = 12
