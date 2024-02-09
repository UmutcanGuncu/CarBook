using System;
using CarBook.Application.Interfaces;
using CarBook.Application.Mediator.Commands.ServiceCommands;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Mediator.Handlers.ServiceHandlers
{
    public class UpdateServiceCommandHandler : IRequestHandler<UpdateServiceCommand>
    {
        private readonly IRepository<Services> _repository;

        public UpdateServiceCommandHandler(IRepository<Services> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateServiceCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            value.Description = request.Description;
            value.IconUrl = request.IconUrl;
            value.Title = request.Title;
            await _repository.UpdateAsync(value);
        }
    }
}

