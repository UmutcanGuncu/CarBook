using System;
using MediatR;

namespace CarBook.Application.Mediator.Commands.LocationCommands
{
	public class RemoveLocationCommand : IRequest
	{
        public Guid Id { get; set; }

        public RemoveLocationCommand(Guid id)
        {
            Id = id;
        }
    }
}

