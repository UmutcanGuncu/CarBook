using System;
using CarBook.Application.Interfaces;
using CarBook.Application.Mediator.Queries.PricingQueries;
using CarBook.Application.Mediator.Results.PricingResults;
using MediatR;

namespace CarBook.Application.Mediator.Handlers.PricingHandlers
{
    public class GetPricingWithCarNameQueryHandler : IRequestHandler<GetPricingWithCarQuery, List<GetPricingWithCarQueryResult>>
    {
        private readonly IPriceRepository _priceRepository;

        public GetPricingWithCarNameQueryHandler(IPriceRepository priceRepository)
        {
            _priceRepository = priceRepository;
        }

        public async Task<List<GetPricingWithCarQueryResult>> Handle(GetPricingWithCarQuery request, CancellationToken cancellationToken)
        {
            var values = await _priceRepository.GetPricingWithCar();
            return values.Select(x => new GetPricingWithCarQueryResult
            {
                PriceId = x.Id,
                AmountDay = x.AmountDay,
                AmountHour = x.AmountHour,
                AmountWeek = x.AmountWeek,
                CarId = x.CarId,
                CarName = x.Car.Model,
                CarImageUrl = x.Car.CoverImageUrl,
                Km = x.Car.Km,
                Transmission = x.Car.Transmission,
                Seat = x.Car.Seat,
                BrandName = x.Car.Brand.Name,
                Fuel = x.Car.Fuel,
                Luggage = x.Car.Luggage
                
            }).ToList();
        }
    }
}

