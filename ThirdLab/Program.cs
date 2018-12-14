using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdLab
{
	class Program
	{
		//Реалізувати ланцюжок наслідування у якому б був звичайний клас, абстрактний
		//	клас та інтерфейс.Перелічити відмінності та подібності у цих структурах у звіті у
		//	вигляді таблиці.
		// Реалізувати різні модифікатори доступу. Продемонструвати доступ до цих
		//	модифікаторів там де він є, та їх відсутність там, де це заборонено (включити в звіт
		//		вирізки з скріншотів Intelisense з VisualStudio).
		//	 Реалізувати поля та класи без модифікаторів доступу.Дослідити який буде доступ
		//за замовчуванням у класів, структур інтерфейсів, вкладених класів, полів, і т.д.У
		//	звіті має бути відповідна таблиця.
		// Оголосити внутрішній клас з доступом меншим за public. Реалізувати поле цього
		//	типу даних.Дослідити обмеження на модифікатор.
		// Реалізувати перелічий тип.Продемонструвати різні булівські операції науван
		//	перелічуваних типах(^,||, &amp;&amp;. &amp;, |,…).
		// Реалізувати множинне наслідування у C#.
		// Реалізувати перевантаження конструкторів базового класу та поточного класу.
		//	Показати різні варіанти використання ключових слів base та this. Реалізувати
		//	перевантаження функції.
		// Реалізувати різні види ініціалізації полів як статичних так і динамічних: за
		//	допомогою статичного та динамічного конструктора, та ін. Дослідити у якій
		//	послідовності ініціалізуються поля.
		// Реалізувати функції з параметрами out, ref. Показати відмінності при наявності та
		//	без цих параметрів. Показати випадки, коли ці параметри не мають значення.
		// Продемонуструвати boxing / unboxing
		// Реалізувати явні та неявні оператори приведення то іншого типу (implicit та
		//explicit)

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
