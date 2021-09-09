using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		public static void paint(int n)
        {
			for (int i = n; i > 0; i--)
			{
				for (int j = i; j > 0; j--)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}
		}
		public static void Main()
		{
			
			paint(15);

		}

	}
}