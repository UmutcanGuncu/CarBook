using System;
using CarBook.Application.Interfaces;
using CarBook.Application.Mediator.Queries.SocialMediaQueries;
using CarBook.Application.Mediator.Results.SocialMediaResults;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Mediator.Handlers.SocialMediaHandlers
{
	public class GetSocialMediaByIdQueryHandler : IRequestHandler<GetSocialMediaByIdQuery, GetSocialMediaByIdQueryResult>
	{
		private readonly IRepository<SocialMedia> _repository;

        public GetSocialMediaByIdQueryHandler(IRepository<SocialMedia> repository)
        {
            _repository = repository;
        }

        public async Task<GetSocialMediaByIdQueryResult> Handle(GetSocialMediaByIdQuery request, CancellationToken cancellationToken)
        {

            var value = await _repository.GetByIdAsync(request.Id);
            return new GetSocialMediaByIdQueryResult
            {
                Id = value.Id,
                Name = value.Name,
                IconUrl = value.IconUrl,
                Url = value.Url
            };
        }
    }
}

