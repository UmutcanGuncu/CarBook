using System;
using MediatR;

namespace CarBook.Application.Mediator.Commands.LocationCommands
{
	public class CreateLocationCommand : IRequest
	{
        public string LocationName { get; set; }
    }
}

