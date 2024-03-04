using System;
using MediatR;

namespace CarBook.Application.Mediator.Commands.TagCloudCommands
{
	public class UpdateTagCloudCommand : IRequest
	{
        public Guid Id { get; set; }
        public string Title { get; set; }
        public Guid BlogId { get; set; }
    }
}

