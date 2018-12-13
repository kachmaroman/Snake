using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondLab
{
	public static class PhoneExtensions
	{
		public static Phone TheMostExpensive(this List<Phone> phones)
		{
			return phones.OrderByDescending(x => x.Price).First();
		}
	}
}
