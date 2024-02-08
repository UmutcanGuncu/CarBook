﻿using System;
using CarBook.Application.CQRS.Commands.CategoryCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.CQRS.Handlers.CategoryHandlers
{
	public class UpdateCategoryCommandHandler
	{
		private readonly IRepository<Category> _repository;

        public UpdateCategoryCommandHandler(IRepository<Category> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateCategoryCommand command)
        {
            var value = await _repository.GetByIdAsync(command.Id);
            value.Name = command.Name;
            await _repository.UpdateAsync(value);
        }
    }
}

