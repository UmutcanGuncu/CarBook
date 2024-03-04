using System;
using CarBook.Application.Interfaces;
using CarBook.Application.Mediator.Queries.TagCloudQueries;
using CarBook.Application.Mediator.Results.TagCloudResult;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Mediator.Handlers.TagCloudHandlers
{
    public class GetTagCloudQueryHandler : IRequestHandler<GetTagCloudQuery, List<GetTagCloudQueryResult>>
    {
        private readonly IRepository<TagCloud> _repository;

        public GetTagCloudQueryHandler(IRepository<TagCloud> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetTagCloudQueryResult>> Handle(GetTagCloudQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetTagCloudQueryResult
            {
                Id = x.Id,
                BlogId = x.BlogId,
                Title = x.Title
            }).ToList();
        }
    }
}

