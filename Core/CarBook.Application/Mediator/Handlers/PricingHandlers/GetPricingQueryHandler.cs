﻿using System;
using CarBook.Application.Interfaces;
using CarBook.Application.Mediator.Queries.PricingQueries;
using CarBook.Application.Mediator.Results.PricingResults;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Mediator.Handlers.PricingHandlers
{
    public class GetPricingQueryHandler : IRequestHandler<GetPricingQuery, List<GetPricingQueryResult>>
    {
        private readonly IRepository<Pricing> _repository;

        public GetPricingQueryHandler(IRepository<Pricing> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetPricingQueryResult>> Handle(GetPricingQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetPricingQueryResult
            {
                Id = x.Id,
                AmountDay = x.AmountDay,
                AmountHour = x.AmountHour,
                AmountWeek = x.AmountWeek,
                CarId = x.CarId
            }).ToList();
        }
    }
}

