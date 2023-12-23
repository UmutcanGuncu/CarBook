using System;
using CarBook.Domain.Common;

namespace CarBook.Domain.Entities
{
	public class Car : BaseEntity
	{
		public Guid BrandId { get; set; }
		public Brand Brand { get; set; }
		public string Model { get; set; }
		public string CoverImageUrl { get; set; }
		public string BigImageUrl { get; set; }
		public int Km { get; set; }
		public string Transmission { get; set; }
		public int Seat { get; set; }
		public int Luggage { get; set; }
		public string Fuel { get; set; }
        public List<CarFeature> CarFeatures { get; set; }
		public CarDescription CarDescription { get; set; }
    }
}

