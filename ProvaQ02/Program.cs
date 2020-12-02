using System;

namespace ProvaQ02
{
  class Program
  {
    static void Main(string[] args)
    {
      int[,] matriz = new int [3,3];
			int n1 = 0, n2 = 1, aux;

			for (int i = 0; i < 3; i++) {
				for (int j = 0; j < 3; j++) {
					matriz[i, j] = n1 + n2;
					aux = n2;
					n2 += n1;
					n1 = aux;

					Console.WriteLine(matriz[i,j]);
				}
			} 
    }
  }
}