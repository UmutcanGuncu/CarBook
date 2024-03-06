using System;
using CarBook.Application.Mediator.Results.CommentResults;
using MediatR;

namespace CarBook.Application.Mediator.Queries.CommentQueries
{
    public class GetCommentByIdQuery : IRequest<GetCommentByIdQueyResult>
	{
		public Guid Id { get; set; }

        public GetCommentByIdQuery(Guid id)
        {
            Id = id;
        }
    }
}

