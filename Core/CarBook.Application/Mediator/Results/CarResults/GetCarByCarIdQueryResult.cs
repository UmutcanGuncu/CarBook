using System;
using CarBook.Domain.Entities;

namespace CarBook.Application.Mediator.Results.CarResults
{
	public class GetCarByCarIdQueryResult
	{

        public Guid BrandId { get; set; }
        public Guid CarId { get; set; }
        public string BrandName { get; set; }
        public string CarModel { get; set; }
        public int AmountHour { get; set; }
        public int AmountDay { get; set; }
        public int AmountWeek { get; set; }
        public string CoverImageUrl { get; set; }
        public string BigImageUrl { get; set; }
        public int Km { get; set; }
        public string Transmission { get; set; }
        public int Seat { get; set; }
        public int Luggage { get; set; }
        public string Fuel { get; set; }
    }
}

