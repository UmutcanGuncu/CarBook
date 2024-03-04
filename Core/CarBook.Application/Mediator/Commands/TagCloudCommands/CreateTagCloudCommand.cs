using System;
using MediatR;

namespace CarBook.Application.Mediator.Commands.TagCloudCommands
{
	public class CreateTagCloudCommand : IRequest
	{
        public string Title { get; set; }
        public Guid BlogId { get; set; }
    }
}

