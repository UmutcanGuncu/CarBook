using System;
using CarBook.Application.Mediator.Results.TagCloudResult;
using MediatR;

namespace CarBook.Application.Mediator.Queries.TagCloudQueries
{
	public class GetTagCloudByIdQuery : IRequest<GetTagCloudByIdQueryResult>
	{
		public Guid Id { get; set; }

        public GetTagCloudByIdQuery(Guid id)
        {
            Id = id;
        }
    }
}

