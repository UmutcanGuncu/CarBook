using System;
using CarBook.Domain.Entities;

namespace CarBook.Application.Mediator.Results.CarResults
{
	public class GetFiveCarQueryResult
	{
        public Guid Id { get; set; }
        public Guid BrandId { get; set; }
        public string BrandName { get; set; }
        public string Model { get; set; }
        public string CoverImageUrl { get; set; }
    }
}

