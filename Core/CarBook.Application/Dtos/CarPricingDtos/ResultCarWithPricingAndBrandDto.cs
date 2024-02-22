
using System;
namespace CarBook.Application.Dtos.CarPricingDtos
{
	public class ResultCarWithPricingAndBrandDto
	{
        public Guid carId { get; set; }
        public string model { get; set; }
        public string brandName { get; set; }
        public string pricingName { get; set; }
        public decimal pricingAmount { get; set; }
        public string coverImageUrl { get; set; }
    }
}

