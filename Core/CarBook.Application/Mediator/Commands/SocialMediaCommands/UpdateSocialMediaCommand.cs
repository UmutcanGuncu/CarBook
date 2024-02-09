using System;
using MediatR;

namespace CarBook.Application.Mediator.Commands.SocialMediaCommands
{
	public class UpdateSocialMediaCommand : IRequest
	{
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string IconUrl { get; set; }
    }
}

