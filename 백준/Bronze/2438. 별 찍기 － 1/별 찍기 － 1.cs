using System;
namespace for문9
{
	class Program
	{
		static void Main(string[] args)
		{
			int star = int.Parse(Console.ReadLine());

			for (int i = 0; i < star; i++)
			{
				for (int j = 0; j < i + 1; j++)
				{
					Console.Write("*");
				}
				Console.Write("\n");
			}

		}
	}
}