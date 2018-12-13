using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdLab
{
	class Program
	{
		static void Main(string[] args)
		{
			Manager manager = new Manager("Alex", "Alexeev", 27, Position.Manager);

			int age = manager;
			Position position = (Position)manager;

			Position someValue = Position.Developer | Position.Manager;
			Position someValue2 = Position.Tester ^ Position.Developer;
			Position someValue3 = Position.Manager & Position.Tester;


			int x = 5, y = 5;
			int result = 0;

			Add(x, y, out int _);
			Substract(x, y, ref result);

			object obj = x;
			int value = (int) obj;
		}

		private static void Add(int x, int y, out int result)
		{
			result = x + y;
		}

		private static void Substract(int x, int y, ref int result)
		{
			result = x * y;
		}
	}
}
