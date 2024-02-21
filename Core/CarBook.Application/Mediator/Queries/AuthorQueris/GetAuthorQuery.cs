using System;
using CarBook.Application.Mediator.Results.AuthorResults;
using MediatR;

namespace CarBook.Application.Mediator.Queries.AuthorQueris
{
	public class GetAuthorQuery : IRequest<List<GetAuthorQueryResult>>
	{
		
	}
}

