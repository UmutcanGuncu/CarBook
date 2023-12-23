using System;
using CarBook.Domain.Common;

namespace CarBook.Domain.Entities
{
	public class CarFeature : BaseEntity
	{
		public Guid FeatureId { get; set; }
		public Feature Feature { get; set; }
		public Guid CarId { get; set; }
		public Car Car { get; set; }
		public bool Avaible { get; set; }
	}
}

