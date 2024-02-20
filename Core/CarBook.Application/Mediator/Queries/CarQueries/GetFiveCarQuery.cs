using System;
using CarBook.Application.Mediator.Results.CarResults;
using MediatR;

namespace CarBook.Application.Mediator.Queries.CarQueries
{
	public class GetFiveCarQuery : IRequest<List<GetFiveCarQueryResult>>
	{
		
	}
}

