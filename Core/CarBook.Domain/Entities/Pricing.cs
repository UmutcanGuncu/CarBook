using System;
using CarBook.Domain.Common;

namespace CarBook.Domain.Entities
{
	public class Pricing : BaseEntity
	{
		public int AmountHour { get; set; }
		public int AmountDay { get; set; }
		public int AmountWeek { get; set; }
		public Guid CarId { get; set; }
		public Car Car { get; set; }
	}
}

