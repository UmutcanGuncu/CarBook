using System;
using CarBook.Application.Interfaces;
using CarBook.Application.Mediator.Queries.PricingQueries;
using CarBook.Application.Mediator.Results.PricingResults;
using MediatR;

namespace CarBook.Application.Mediator.Handlers.PricingHandlers
{
    public class GetPricingWithCarAndBrandByCarIdQueryHandler : IRequestHandler<GetPricingWithCarAndBrandByBrandIdQuery, List<GetPricingWithCarAndBrandByBrandIdQueryResult>>
    {
        private readonly IPriceRepository _priceRepository;

        public GetPricingWithCarAndBrandByCarIdQueryHandler(IPriceRepository priceRepository)
        {
            _priceRepository = priceRepository;
        }

        public async Task<List<GetPricingWithCarAndBrandByBrandIdQueryResult>> Handle(GetPricingWithCarAndBrandByBrandIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _priceRepository.GetPricingWithCarAndBrandByBrandId(request.BrandId);
            return values.Select(x => new GetPricingWithCarAndBrandByBrandIdQueryResult
            {
                BrandId = x.Car.BrandId,
                CarId = x.CarId,
                PriceId = x.Id,
                AmountDay = x.AmountDay,
                AmountHour = x.AmountHour,
                AmountWeek = x.AmountWeek,
                Seat = x.Car.Seat,
                BigImageUrl = x.Car.BigImageUrl,
                CoverImageUrl = x.Car.CoverImageUrl,
                BrandName = x.Car.Brand.Name,
                CarName = x.Car.Model,
                Fuel = x.Car.Fuel,
                Km = x.Car.Km,
                Luggage = x.Car.Luggage,
                Transmission = x.Car.Transmission


            }).ToList();
        }
    }
    
}

