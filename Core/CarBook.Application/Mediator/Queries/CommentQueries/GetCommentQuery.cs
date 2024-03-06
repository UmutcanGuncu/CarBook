using System;
using CarBook.Application.Mediator.Results.CommentResults;
using MediatR;

namespace CarBook.Application.Mediator.Queries.CommentQueries
{
	public class GetCommentQuery : IRequest<List<GetCommentQueryResult>>
	{
		
	}
}

