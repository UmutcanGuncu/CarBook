using System;
using CarBook.Application.Mediator.Results.PricingResults;
using MediatR;

namespace CarBook.Application.Mediator.Queries.PricingQueries
{
	public class GetPricingWithCarAndBrandByBrandIdQuery : IRequest<List<GetPricingWithCarAndBrandByBrandIdQueryResult>>
	{
		public Guid BrandId { get; set; }

        public GetPricingWithCarAndBrandByBrandIdQuery(Guid brandId)
        {
            BrandId = brandId;
        }
    }
}

