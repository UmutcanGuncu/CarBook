using System;
namespace CarBook.Application.Mediator.Results.PricingResults
{
	public class GetPricingWithCarQueryResult
	{
        public Guid PriceId { get; set; }
        public int AmountHour { get; set; }
        public int AmountDay { get; set; }
        public int AmountWeek { get; set; }
        public string CarName { get; set; }
        public string BrandName { get; set; }
        public string CarImageUrl { get; set; }
        public int Km { get; set; }
        public string Transmission { get; set; }
        public int Seat { get; set; }
        public int Luggage { get; set; }
        public string Fuel { get; set; }
        public Guid CarId { get; set; }
    }
}

