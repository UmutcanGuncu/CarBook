using System;
using CarBook.Application.Mediator.Results.FeatureResults;
using MediatR;

namespace CarBook.Application.Mediator.Queries.FeatureQueries
{
	public class GetFeatureByIdQuery : IRequest<GetFeatureByIdQueryResult>
	{
		public Guid Id { get; set; }

        public GetFeatureByIdQuery(Guid id)
        {
            Id = id;
        }
    }
}

