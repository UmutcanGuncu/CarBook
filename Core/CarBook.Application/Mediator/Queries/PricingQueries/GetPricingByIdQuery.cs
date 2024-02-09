using System;
using CarBook.Application.Mediator.Results.PricingResults;
using MediatR;

namespace CarBook.Application.Mediator.Queries.PricingQueries
{
	public class GetPricingByIdQuery : IRequest<GetPricingByIdQueryResult>
	{
		public Guid Id { get; set; }

        public GetPricingByIdQuery(Guid id)
        {
            Id = id;
        }
    }
}

