using System;
using CarBook.Application.Interfaces;
using CarBook.Application.Mediator.Queries.FeatureQueries;
using CarBook.Application.Mediator.Results.FeatureResults;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Mediator.Handlers.FeatureHandlers
{
    public class GetFeatureQueryHandler : IRequestHandler<GetFeatureQuery, List<GetFeatureQueryResult>> // istek GetFeatureQuery'den yapılacak, Cevap Olarak Da Liste Türünde GetFeatureQueryResult Dönecek
    {
        private readonly IRepository<Feature> _repository;

        public GetFeatureQueryHandler(IRepository<Feature> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetFeatureQueryResult>> Handle(GetFeatureQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetFeatureQueryResult
            {
                Id = x.Id,
                Name = x.Name

            }).ToList();
        }
    }
}

