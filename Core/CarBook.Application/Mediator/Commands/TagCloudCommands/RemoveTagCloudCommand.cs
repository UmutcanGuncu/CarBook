using System;
using MediatR;

namespace CarBook.Application.Mediator.Commands.TagCloudCommands
{
	public class RemoveTagCloudCommand : IRequest
	{
		public Guid Id { get; set; }

        public RemoveTagCloudCommand(Guid id)
        {
            Id = id;
        }
    }
}

