using System;
namespace CarBook.Application.Dtos.PriceDtos
{
	public class CreatePriceDto
	{
        public int AmountHour { get; set; }
        public int AmountDay { get; set; }
        public int AmountWeek { get; set; }
        public Guid CarId { get; set; }
    }
}

