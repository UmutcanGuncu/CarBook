﻿using System;
using CarBook.Application.CQRS.Commands.ContactCommand;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.CQRS.Handlers.ContactHandlers
{
	public class UpdateContactCommandHandler
	{
		private readonly IRepository<Contact> _repository;

        public UpdateContactCommandHandler(IRepository<Contact> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateContactCommand command)
        {
            var value = await _repository.GetByIdAsync(command.Id);
            value.Name = command.Name;
            value.Email = command.Email;
            value.Subject = command.Subject;
            value.Message = command.Message;
            value.SendDate = command.SendDate;
            await _repository.UpdateAsync(value);
        }
    }
}

