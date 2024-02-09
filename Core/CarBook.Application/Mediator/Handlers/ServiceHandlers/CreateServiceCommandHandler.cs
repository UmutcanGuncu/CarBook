using System;
using CarBook.Application.Interfaces;
using CarBook.Application.Mediator.Commands.ServiceCommands;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Mediator.Handlers.ServiceHandlers
{
    public class CreateServiceCommandHandler : IRequestHandler<CreateServiceCommand>
    {
        private readonly IRepository<Services> _repository;

        public CreateServiceCommandHandler(IRepository<Services> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateServiceCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Services
            {
                Description = request.Description,
                IconUrl = request.IconUrl,
                Title = request.Title
            });
        }
    }
}

