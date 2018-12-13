using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondLab
{
	public class Sort : IComparer<Phone>
	{
		public int Compare(Phone x, Phone y)
		{
			return y.Price - x.Price;
		}
	}
}
