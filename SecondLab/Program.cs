using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondLab
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Phone> phones = Data.Feed();

			//1.Селекція частини інформації(метод Select)
			List<string> models = phones.Select(x => x.Model).ToList();

			Console.WriteLine("1");
			models.ForEach(Console.WriteLine);
			Console.WriteLine();

			//2.Вибірка певної інформації(Where)
			List<Phone> phonesOfSamsung = phones
												.Where(x => x.Company.Equals("Samsung", StringComparison.InvariantCultureIgnoreCase))
												.ToList();

			PrintList("2", phonesOfSamsung);

			//3.Операції як з списком List так і з словником Dictionary
			Dictionary<string, int> dictionaryOfPhones = phones.ToDictionary(x => x.Model, x => x.Price);

			PrintDictionary("3", dictionaryOfPhones);

			//4.Реалізувати власні методи розширювання.
			Phone theMostExpensivePhone = phones.TheMostExpensive();

			Console.WriteLine("4");
			Console.WriteLine($"{theMostExpensivePhone.Company} - {theMostExpensivePhone.Model} - {theMostExpensivePhone.Price}");
			Console.WriteLine();

			//5.Показати використання анонімних класів та ініціалізаторів
			var unknownObject = new { Name = "Milk", Price = 3.5d };

			Console.WriteLine("5");
			Console.WriteLine($"{unknownObject.Name} - {unknownObject.Price}");
			Console.WriteLine();

			//6.Відсортувати за якимось критерієм використовуючи шаблон IComparer.
			phones.Sort(new Sort());

			PrintList("6", phones);

			//7.Конвертувати списки в масив.
			Phone[] arrayOfPhones = phones.ToArray();

			PrintList("7", arrayOfPhones);

			//8.Відсортувати масив / список за ім’ям чи за кількістю елементів.
			phones.Sort((x, y) => y.Company.GetHashCode() - x.Company.GetHashCode());

			PrintList("8", phones);

			Console.ReadKey();
		}

		private static void PrintList(string text, IEnumerable<Phone> phones)
		{
			Console.WriteLine(text);

			foreach (Phone phone in phones)
			{
				Console.WriteLine($"{phone.Company} - {phone.Model} - {phone.Price:C}");
			}

			Console.WriteLine();
		}

		private static void PrintDictionary(string text, Dictionary<string, int> dictionary)
		{
			Console.WriteLine(text);

			foreach (KeyValuePair<string, int> keyValuePair in dictionary)
			{
				Console.WriteLine($"{keyValuePair.Key} - {keyValuePair.Value}");
			}

			Console.WriteLine();
		}
	}
}
