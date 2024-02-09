using System;
using CarBook.Application.Interfaces;
using CarBook.Application.Mediator.Commands.LocationCommands;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Mediator.Handlers.LocationHandlers
{
    public class UpdateLocationCommandHandler : IRequestHandler<UpdateLocationCommand>
    {
        private readonly IRepository<Location> _repository;

        public UpdateLocationCommandHandler(IRepository<Location> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateLocationCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            value.LocationName = request.LocationName;
            await _repository.UpdateAsync(value);
        }
    }
}

