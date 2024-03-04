using System;
using CarBook.Application.Mediator.Results.TagCloudResult;
using MediatR;

namespace CarBook.Application.Mediator.Queries.TagCloudQueries
{
	public class GetTagCloudQuery : IRequest<List<GetTagCloudQueryResult>>
	{
		
	}
}

