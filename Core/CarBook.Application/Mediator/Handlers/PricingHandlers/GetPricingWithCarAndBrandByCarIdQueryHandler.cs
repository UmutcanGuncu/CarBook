using System;
using CarBook.Application.Interfaces;
using CarBook.Application.Mediator.Queries.PricingQueries;
using CarBook.Application.Mediator.Results.PricingResults;
using MediatR;

namespace CarBook.Application.Mediator.Handlers.PricingHandlers
{
    public class GetPricingWithCarAndBrandByCarIdQueryHandler : IRequestHandler<GetPricingWithCarAndBrandByCarIdQuery, GetPricingWithCarAndBrandByCarIdQueryResult>
    {
        private readonly IPriceRepository _priceRepository;

        public GetPricingWithCarAndBrandByCarIdQueryHandler(IPriceRepository priceRepository)
        {
            _priceRepository = priceRepository;
        }

        public async Task<GetPricingWithCarAndBrandByCarIdQueryResult> Handle(GetPricingWithCarAndBrandByCarIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _priceRepository.GetPricingWithCarAndBrandByCarId(request.CarId);
            return new GetPricingWithCarAndBrandByCarIdQueryResult
            {
                BrandId = value.Car.BrandId,
                CarId = value.CarId,
                PriceId = value.Id,
                AmountDay = value.AmountDay,
                AmountHour = value.AmountHour,
                AmountWeek = value.AmountWeek,
                BrandName = value.Car.Brand.Name,
                CarName = value.Car.Model,
                Fuel = value.Car.Fuel,
                Km = value.Car.Km,
                Luggage = value.Car.Luggage,
                Seat = value.Car.Seat,
                Transmission = value.Car.Transmission,
                CoverImageUrl = value.Car.CoverImageUrl,
                BigImageUrl = value.Car.BigImageUrl
            };
        }
    }
}

