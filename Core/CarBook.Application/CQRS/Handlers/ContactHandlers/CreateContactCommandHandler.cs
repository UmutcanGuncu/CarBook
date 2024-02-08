using System;
using CarBook.Application.CQRS.Commands.ContactCommand;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.CQRS.Handlers.ContactHandlers
{
	public class CreateContactCommandHandler
	{
		private readonly IRepository<Contact> _repository;

        public CreateContactCommandHandler(IRepository<Contact> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateContactCommand command)
        {
            await _repository.CreateAsync(new Contact
            {
                Name = command.Name,
                Email = command.Email,
                Subject = command.Subject,
                Message = command.Message,
                SendDate = command.SendDate
            });
        }
    }
}

