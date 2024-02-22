using System;
namespace CarBook.Application.Dtos.PriceDtos
{
	public class ResultPriceWithCarDto
	{
        public Guid id { get; set; }
        public int amountHour { get; set; }
        public int amountDay { get; set; }
        public int amountWeek { get; set; }
        public string carName { get; set; }
        public string carImageUrl { get; set; }
    }
}

