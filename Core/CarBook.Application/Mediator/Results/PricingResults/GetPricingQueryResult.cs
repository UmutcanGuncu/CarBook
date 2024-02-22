using System;
namespace CarBook.Application.Mediator.Results.PricingResults
{
	public class GetPricingQueryResult
	{
		public Guid Id { get; set; }
        public int AmountHour { get; set; }
        public int AmountDay { get; set; }
        public int AmountWeek { get; set; }
        public Guid CarId { get; set; }

    }
}

