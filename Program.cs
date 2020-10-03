using System;

namespace Exercicio_5
{
	class Program
	{
		static void Main(string[] args)
		{
			int a;

			Console.WriteLine("Digite sua idade: ");
			a = Convert.ToInt32(Console.ReadLine());

			if (a > 18)
			{
				Console.WriteLine("Você é maior de idade");
			}
			if (a < 18)
			{
				Console.WriteLine("Você é menor de idade");
			}
			Console.ReadKey();
		}
	}
}