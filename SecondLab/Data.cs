using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondLab
{
	public static class Data
	{
		public static List<Phone> Feed()
		{
			List<Phone> phones = new List<Phone>
			{
				new Phone("5S", "Apple", 200),
				new Phone("6", "Apple", 350),
				new Phone("6+", "Apple", 380),
				new Phone("6S+", "Apple", 400),
				new Phone("SE", "Apple", 450),
				new Phone("7", "Apple", 600),
				new Phone("7+", "Apple", 620),
				new Phone("8", "Apple", 670),
				new Phone("8+", "Apple", 700),
				new Phone("X", "Apple", 900),
				new Phone("XR", "Apple", 850),
				new Phone("XS", "Apple", 1400),
				new Phone("S8", "Samsung", 1000),
				new Phone("S9", "Samsung", 1200),
				new Phone("S9+", "Samsung", 1400)
			};

			return phones;
		}
	}
}
