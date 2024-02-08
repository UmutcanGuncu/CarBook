using System;
using CarBook.Application.CQRS.Commands.BrandCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.CQRS.Handlers.BrandHandlers
{
	public class UpdateBrandCommandHandler
	{
		private readonly IRepository<Brand> _repository;

        public UpdateBrandCommandHandler(IRepository<Brand> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateBrandCommand command)
        {
            var value = await _repository.GetByIdAsync(command.Id);
            value.Name = command.Name;
            await _repository.UpdateAsync(value);
        }
    }
}

