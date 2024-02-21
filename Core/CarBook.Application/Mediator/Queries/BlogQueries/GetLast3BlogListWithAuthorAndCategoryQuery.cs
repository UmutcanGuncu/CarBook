using System;
using CarBook.Application.Mediator.Results.BlogResults;
using MediatR;

namespace CarBook.Application.Mediator.Queries.BlogQueries
{
	public class GetLast3BlogListWithAuthorAndCategoryQuery : IRequest<List<GetLast3BlogListWithAuthorAndCategoryQueryResult>>
	{
		
	}
}

