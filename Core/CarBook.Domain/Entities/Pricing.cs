using System;
using CarBook.Domain.Common;

namespace CarBook.Domain.Entities
{
	public class Pricing : BaseEntity
	{
		public string Name { get; set; }
		public List<CarPricing> CarPricings { get; set; }
	}
}

