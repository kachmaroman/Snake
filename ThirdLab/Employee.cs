using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdLab
{
	public interface IHuman
	{
		string FirstName { get; set; }
		string LastName { get; set; }
		int Age { get; set; }
	}

	public abstract class Employee : IHuman
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int Age { get; set; }
		protected Position Position { get; set; }
		private decimal Salary { get; set; }
	}

	public class Manager : Employee
	{
		Guid Id { get; set; }

		private InternalClass internalClass;

		public Manager(string firstName, string lastName, int age, Position position)
		{
			Id = Guid.NewGuid();
			FirstName = firstName;
			LastName = lastName;
			Age = age;
			Position = position;

			internalClass = new InternalClass();
		}

		protected class InternalClass
		{
		}
	}

	[Flags]
	public enum Position
	{
		Manager = 1,
		Developer,
		Tester
	}
}
