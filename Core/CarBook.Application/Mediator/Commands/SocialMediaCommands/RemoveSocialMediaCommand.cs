using System;
using MediatR;

namespace CarBook.Application.Mediator.Commands.SocialMediaCommands
{
	public class RemoveSocialMediaCommand : IRequest
	{
        public RemoveSocialMediaCommand(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; set; }
	}
}

