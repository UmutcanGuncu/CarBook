using System;
using MediatR;

namespace CarBook.Application.Mediator.Commands.LocationCommands
{
	public class UpdateLocationCommand : IRequest
	{
        public Guid Id { get; set; }
        public string LocationName { get; set; }
    }
}

