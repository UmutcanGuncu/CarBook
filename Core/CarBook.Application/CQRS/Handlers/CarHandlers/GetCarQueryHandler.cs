﻿using System;
using CarBook.Application.CQRS.Results.CarResult;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.CQRS.Handlers.CarHandlers
{
	public class GetCarQueryHandler
	{
		private readonly IRepository<Car> _repository;

        public GetCarQueryHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }
        public async Task<List<GetCarQueryResult>> Handle()
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetCarQueryResult
            {
               Id = x.Id,
               BrandId = x.BrandId,
               BigImageUrl =x.BigImageUrl,
               CoverImageUrl = x.CoverImageUrl,
               Fuel = x.Fuel,
               Km = x.Km,
               Luggage = x.Luggage,
               Model = x.Model,
               Seat = x.Seat,
               Transmission = x.Transmission

            }).ToList();
        }
    }
}

