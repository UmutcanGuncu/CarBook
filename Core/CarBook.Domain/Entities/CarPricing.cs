using System;
using CarBook.Domain.Common;

namespace CarBook.Domain.Entities
{
	public class CarPricing : BaseEntity
	{
		public Guid CarId { get; set; }
		public Car Car { get; set; }
		public Guid PricingId { get; set; }
		public Pricing Pricing { get; set; }
		public decimal Amount { get; set; }
	}
}

