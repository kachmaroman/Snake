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

			Position operation = Position.Developer | Position.Manager;

			Console.WriteLine(000100);

		}
	}
}
