using System;
using CarBook.Application.Mediator.Results.BlogResults;
using MediatR;

namespace CarBook.Application.Mediator.Queries.BlogQueries
{
	public class GetBlogByAuthorIdQuery : IRequest<GetBlogByAuthorIdQueryResult>
	{
        public GetBlogByAuthorIdQuery(Guid authorId, Guid blogId)
        {
            AuthorId = authorId;
            BlogId = blogId;
        }

        public Guid AuthorId { get; set; }
		public Guid BlogId { get; set; }
	}
}

