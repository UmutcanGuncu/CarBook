using System;
using CarBook.Domain.Entities;

namespace CarBook.Application.CQRS.Results.CarResult
{
	public class GetCarQueryResult
	{
        public Guid Id { get; set; }
        public Guid BrandId { get; set; }
        public string Model { get; set; }
        public string CoverImageUrl { get; set; }
        public string BigImageUrl { get; set; }
        public int Km { get; set; }
        public string Transmission { get; set; }
        public int Seat { get; set; }
        public int Luggage { get; set; }
        public string Fuel { get; set; }
    }
}

