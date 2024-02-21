using System;
using CarBook.Application.Mediator.Results.BlogResults;
using MediatR;

namespace CarBook.Application.Mediator.Queries.BlogQueries
{
	public class GetBlogByIdQuery : IRequest<GetBlogByIdQueryResult>
	{
		public Guid Id { get; set; }

        public GetBlogByIdQuery(Guid id)
        {
            Id = id;
        }
    }
}

