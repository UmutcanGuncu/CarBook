using System;
using CarBook.Application.CQRS.Commands.AboutCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.CQRS.Handlers.AboutHandlers
{
	public class UpdateAboutCommandHandler
	{
		private readonly IRepository<About> _repository;

        public UpdateAboutCommandHandler(IRepository<About> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateAboutCommand command)
        {
            var value = await _repository.GetByIdAsync(command.Id);
            value.Description = command.Description;
            value.Title = command.Title;
            value.ImageUrl = command.ImageUrl;
            await _repository.UpdateAsync(value);
        }
    }
}

