using System;
using CarBook.Application.Mediator.Results.ServiceResults;
using MediatR;

namespace CarBook.Application.Mediator.Queries.ServiceQueries
{
	public class GetServiceQuery : IRequest<List<GetServiceQueryResult>>
	{
		
	}
}

