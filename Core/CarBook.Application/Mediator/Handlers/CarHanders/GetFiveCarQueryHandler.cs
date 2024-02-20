using System;
using CarBook.Application.Interfaces;
using CarBook.Application.Mediator.Queries.CarQueries;
using CarBook.Application.Mediator.Results.CarResults;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Mediator.Handlers.CarHanders
{
    public class GetFiveCarQueryHandler : IRequestHandler<GetFiveCarQuery, List<GetFiveCarQueryResult>>
    {
        private readonly ICarRepository _carRepository;

        public GetFiveCarQueryHandler(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public async Task<List<GetFiveCarQueryResult>> Handle(GetFiveCarQuery request, CancellationToken cancellationToken)
        {
            var values = await _carRepository.GetFiveCarList();
            return values.Select(x => new GetFiveCarQueryResult
            {
                Id = x.Id,
                BrandId = x.BrandId,
                BrandName = x.Brand.Name,
                CoverImageUrl = x.CoverImageUrl,
                Model = x.Model
            }).ToList();
            
        }
    }
}

