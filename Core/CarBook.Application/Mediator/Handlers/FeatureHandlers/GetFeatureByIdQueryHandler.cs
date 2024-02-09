using System;
using CarBook.Application.Interfaces;
using CarBook.Application.Mediator.Queries.FeatureQueries;
using CarBook.Application.Mediator.Results.FeatureResults;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Mediator.Handlers.FeatureHandlers
{
    public class GetFeatureByIdQueryHandler : IRequestHandler<GetFeatureByIdQuery, GetFeatureByIdQueryResult>
    {
        private readonly IRepository<Feature> _repository;

        public GetFeatureByIdQueryHandler(IRepository<Feature> repository)
        {
            _repository = repository;
        }

        public async Task<GetFeatureByIdQueryResult> Handle(GetFeatureByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            return new GetFeatureByIdQueryResult
            {
                Id = value.Id,
                Name = value.Name
            };
        }
    }
}

