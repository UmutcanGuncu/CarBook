using System;
using MediatR;

namespace CarBook.Application.Mediator.Commands.ServiceCommands
{
	public class RemoveServiceCommand : IRequest
	{
		public Guid Id { get; set; }

        public RemoveServiceCommand(Guid id)
        {
            Id = id;
        }
    }
}

