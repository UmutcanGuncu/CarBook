﻿using System;
using CarBook.Application.CQRS.Commands.AboutCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.CQRS.Handlers.AboutHandlers
{
	public class RemoveAboutCommandHandler
	{
		private readonly IRepository<About> _repository;

        public RemoveAboutCommandHandler(IRepository<About> repository)
        {
            _repository = repository;
        }
        public async Task Handle(RemoveAboutCommand command)
        {
            var value = await _repository.GetByIdAsync(command.Id);
            await _repository.DeleteAsync(value);
        }
    }
}
