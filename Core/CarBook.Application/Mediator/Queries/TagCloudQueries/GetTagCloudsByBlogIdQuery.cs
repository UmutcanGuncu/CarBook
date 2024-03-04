using System;
using CarBook.Application.Mediator.Results.TagCloudResult;
using MediatR;

namespace CarBook.Application.Mediator.Queries.TagCloudQueries
{
	public class GetTagCloudsByBlogIdQuery : IRequest<List<GetTagCloudByIdQueryResult>>
	{
		public Guid BlogId { get; set; }

        public GetTagCloudsByBlogIdQuery(Guid blogId)
        {
            BlogId = blogId;
        }
    }
}

