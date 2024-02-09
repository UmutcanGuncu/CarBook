using System;
using MediatR;

namespace CarBook.Application.Mediator.Commands.SocialMediaCommands
{
	public class CreateSocialMediaCommand : IRequest
	{
        public string Name { get; set; }
        public string Url { get; set; }
        public string IconUrl { get; set; }
    }
}

