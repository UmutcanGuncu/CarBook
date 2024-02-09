using System;
using CarBook.Application.Mediator.Results.ServiceResults;
using MediatR;

namespace CarBook.Application.Mediator.Queries.ServiceQueries
{
	public class GetServiceByIdQuery : IRequest<GetServiceByIdQueryResult>
	{
		public Guid Id { get; set; }

        public GetServiceByIdQuery(Guid id)
        {
            Id = id;
        }
    }
}

