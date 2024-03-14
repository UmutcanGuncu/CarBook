using System;
namespace CarBook.Application.Dtos.PriceDtos
{
	public class UpdatePriceDto
	{
		public Guid id { get; set; }
		public int amountHour { get; set; }
		public int amountDay { get; set; }
		public int amountWeek { get; set; }
		public Guid carId { get; set; }
    }
}

