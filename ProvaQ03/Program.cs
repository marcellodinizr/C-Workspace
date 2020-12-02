using System;

namespace ProvaQ03
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] vetor = {5, 20, 43, 57, 90, 95};
			int soma = 0;
			for(int i = 0; i < 6; i++) {
				if(vetor[i] % 2 != 0 && vetor[i] % 5 == 0) {
					soma += vetor[i];		
					}
				}
			Console.WriteLine(soma);
		}
	}
}
