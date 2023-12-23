using System;
using CarBook.Domain.Common;

namespace CarBook.Domain.Entities
{
	public class CarDescription : BaseEntity
	{
		public string Detail { get; set; }
		public Guid CarId { get; set; }
		public Car Car { get; set; }
	}
}

