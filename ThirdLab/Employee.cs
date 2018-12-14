using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdLab
{
	public interface IInfo
	{
		string GetInfo();
	}

	public interface IHuman
	{
		string FirstName { get; set; }
		string LastName { get; set; }
		int Age { get; set; }
	}

	public abstract class Employee : IHuman, IInfo
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int Age { get; set; }
		protected Position Position { get; set; }
		private decimal Salary { get; set; }

		public abstract string GetInfo();
	}

	public class Manager : Employee
	{
		Guid Id { get; set; }

		private InternalClass internalClass;

		public Manager()
		{
			internalClass = new InternalClass();
			internalClass.SomeValue = 20;
			Id = Guid.NewGuid();
		}

		public Manager(string firstName, string lastName) : this()
		{
			FirstName = firstName;
			LastName = lastName;
		}

		public Manager(string firstName, string lastName, int age, Position position) : this(firstName, lastName)
		{
			Age = age;
			Position = position;

			internalClass = new InternalClass();
		}

		public static implicit operator int(Manager manager)
		{
			return manager.Age;
		}

		public static explicit operator Position(Manager manager)
		{
			return manager.Position;
		}

		public override string GetInfo()
		{
			return $"{FirstName} - {LastName} - {Age} - {Position}";
		}

		protected class InternalClass
		{
			public int SomeValue { get; set; }
		}
	}

	public class ProjectManager : Manager
	{
		public static Guid Id { get; set; }

		static ProjectManager()
		{
			Id = Guid.NewGuid();
		}

		public ProjectManager(string firstName, string lastName, int age) : base(firstName, lastName, age, Position.PM)
		{
			
		}
	}

	[Flags]
	public enum Position
	{
		Manager,
		Developer,
		Tester,
		PM
	}
}
