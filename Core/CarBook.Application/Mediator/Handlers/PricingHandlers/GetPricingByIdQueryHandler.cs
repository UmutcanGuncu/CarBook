using System;
using CarBook.Application.Interfaces;
using CarBook.Application.Mediator.Queries.PricingQueries;
using CarBook.Application.Mediator.Results.PricingResults;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Mediator.Handlers.PricingHandlers
{
    public class GetPricingByIdQueryHandler : IRequestHandler<GetPricingByIdQuery, GetPricingByIdQueryResult>
    {
        private readonly IRepository<Pricing> _repository;

        public GetPricingByIdQueryHandler(IRepository<Pricing> repository)
        {
            _repository = repository;
        }

        public async Task<GetPricingByIdQueryResult> Handle(GetPricingByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            return new GetPricingByIdQueryResult
            {
                Id = value.Id,
                AmountDay = value.AmountDay,
                AmountHour = value.AmountHour,
                AmountWeek = value.AmountHour
            };
        }
    }
}

