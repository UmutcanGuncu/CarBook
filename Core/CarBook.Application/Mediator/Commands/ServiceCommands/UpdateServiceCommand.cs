using System;
using MediatR;

namespace CarBook.Application.Mediator.Commands.ServiceCommands
{
	public class UpdateServiceCommand : IRequest
	{
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string IconUrl { get; set; }
    }
}

