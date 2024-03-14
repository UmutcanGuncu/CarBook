using System;
using CarBook.Application.Mediator.Results.PricingResults;
using MediatR;

namespace CarBook.Application.Mediator.Queries.PricingQueries
{
	public class GetPricingWithCarAndBrandByCarIdQuery : IRequest<GetPricingWithCarAndBrandByCarIdQueryResult>
	{
		public Guid CarId { get; set; }

        public GetPricingWithCarAndBrandByCarIdQuery(Guid carId)
        {
            CarId = carId;
        }
    }
}

