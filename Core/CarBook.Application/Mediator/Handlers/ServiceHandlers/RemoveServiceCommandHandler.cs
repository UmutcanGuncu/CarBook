using System;
using CarBook.Application.Interfaces;
using CarBook.Application.Mediator.Commands.ServiceCommands;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Mediator.Handlers.ServiceHandlers
{
    public class RemoveServiceCommandHandler : IRequestHandler<RemoveServiceCommand>
    {
        private readonly IRepository<Services> _repository;

        public RemoveServiceCommandHandler(IRepository<Services> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveServiceCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            await _repository.DeleteAsync(value);
        }
    }
}

