using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondLab
{
	public class Phone
	{
		public Phone(string model, string company, int price)
		{
			Model = model;
			Company = company;
			Price = price;
		}

		public string Model { get; set; }

		public string Company { get; set; }

		public int Price { get; set; }

	}
}
