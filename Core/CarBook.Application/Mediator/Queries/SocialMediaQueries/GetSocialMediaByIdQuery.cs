using System;
using CarBook.Application.Mediator.Results.SocialMediaResults;
using MediatR;

namespace CarBook.Application.Mediator.Queries.SocialMediaQueries
{
	public class GetSocialMediaByIdQuery : IRequest<GetSocialMediaByIdQueryResult>
	{
		public Guid Id { get; set; }

        public GetSocialMediaByIdQuery(Guid id)
        {
            Id = id;
        }
    }
}

