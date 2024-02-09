using System;
using CarBook.Application.Interfaces;
using CarBook.Application.Mediator.Queries.SocialMediaQueries;
using CarBook.Application.Mediator.Results.SocialMediaResults;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Mediator.Handlers.SocialMediaHandlers
{
	public class GetSocialMediaQueryHandler : IRequestHandler<GetSocialMediaQuery, List<GetSocialMediaQueryResult>>
	{
		private readonly IRepository<SocialMedia> _repository;

        public GetSocialMediaQueryHandler(IRepository<SocialMedia> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetSocialMediaQueryResult>> Handle(GetSocialMediaQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetSocialMediaQueryResult
            {
                Id = x.Id,
                Name = x.Name,
                IconUrl = x.IconUrl,
                Url = x.Url
            }).ToList();
        }
    }
}

