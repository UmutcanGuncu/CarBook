using System;
namespace CarBook.Application.Dtos.PriceDtos
{
	public class ResultPriceWithCarAndBrandDto
	{
        public Guid priceId { get; set; }
        public Guid carId { get; set; }
        public Guid brandId { get; set; }
        public int amountHour { get; set; }
        public int amountDay { get; set; }
        public int amountWeek { get; set; }
        public string brandName { get; set; }
        public string model { get; set; }
        public int km { get; set; }
        public string transmission { get; set; }
        public int seat { get; set; }
        public int luggage { get; set; }
        public string fuel { get; set; }
        
    }
}

