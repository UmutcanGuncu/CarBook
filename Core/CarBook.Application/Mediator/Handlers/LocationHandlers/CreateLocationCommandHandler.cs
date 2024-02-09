﻿using System;
using CarBook.Application.Interfaces;
using CarBook.Application.Mediator.Commands.LocationCommands;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Mediator.Handlers.LocationHandlers
{
    public class CreateLocationCommandHandler : IRequestHandler<CreateLocationCommand>
    {
        private readonly IRepository<Location> _repository;

        public CreateLocationCommandHandler(IRepository<Location> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateLocationCommand request, CancellationToken cancellationToken)
        {

            await _repository.CreateAsync(new Location
            {
                LocationName = request.LocationName
            });
        }
    }
}

