using System;
using CarBook.Application.CQRS.Commands.CarCommands;
using CarBook.Application.CQRS.Results.CarResult;
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
        public async Task <CreateCarCommandResult> Handle(CreateCarCommand command)
        {
            Car car = new Car()
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
            };

            await _repository.CreateAsync(car);
            return new CreateCarCommandResult
            {
                CarId = car.Id
            };
        }
    }
}

