using System;
using CarBook.Application.Mediator.Results.LocationResults;
using MediatR;

namespace CarBook.Application.Mediator.Queries.LocationQueries
{
	public class GetLocationByIdQuery : IRequest<GetLocationByIdQueryResult>
	{
		public Guid Id { get; set; }

        public GetLocationByIdQuery(Guid id)
        {
            Id = id;
        }
    }
}

