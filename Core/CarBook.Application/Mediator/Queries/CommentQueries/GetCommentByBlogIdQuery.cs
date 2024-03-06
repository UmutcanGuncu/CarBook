using System;
using CarBook.Application.Mediator.Results.CommentResults;
using MediatR;

namespace CarBook.Application.Mediator.Queries.CommentQueries
{
	public class GetCommentByBlogIdQuery : IRequest<List<GetCommentByBlogIdQueryResult>>
	{
		public Guid BlogId { get; set; }

        public GetCommentByBlogIdQuery(Guid blogId)
        {
            BlogId = blogId;
        }
    }
}

