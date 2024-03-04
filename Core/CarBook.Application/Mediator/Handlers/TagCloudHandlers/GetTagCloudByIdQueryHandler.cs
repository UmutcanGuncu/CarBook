using System;
using CarBook.Application.Interfaces;
using CarBook.Application.Mediator.Queries.TagCloudQueries;
using CarBook.Application.Mediator.Results.TagCloudResult;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Mediator.Handlers.TagCloudHandlers
{
    public class GetTagCloudByIdQueryHandler : IRequestHandler<GetTagCloudByIdQuery, GetTagCloudByIdQueryResult>
    {
        private readonly IRepository<TagCloud> _repository;

        public GetTagCloudByIdQueryHandler(IRepository<TagCloud> repository)
        {
            _repository = repository;
        }

        public async Task<GetTagCloudByIdQueryResult> Handle(GetTagCloudByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            return new GetTagCloudByIdQueryResult
            {
                Id = value.Id,
                BlogId = value.BlogId,
                Title = value.Title
            };
        }
    }
}

