using System;
using CarBook.Application.CQRS.Commands.CarCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.CQRS.Handlers.CarHandlers
{
	public class CreateCarCommandHandler
	{
		private readonly IRepository<Car> _repository;

        public CreateCarCommandHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }
        public async Task Handle(CreateCarCommand command)
        {
            await _repository.CreateAsync(new Car
            {
                BrandId = command.BrandId,
                BigImageUrl = command.BigImageUrl,
                Fuel = command.Fuel,
                Seat = command.Seat,
                Model = command.Model,
                Luggage = command.Luggage,
                Transmission = command.Transmission,
                Km = command.Km,
                CoverImageUrl = command.CoverImageUrl
            });
        }
    }
}

