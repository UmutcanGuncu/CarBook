using System;
using MediatR;

namespace CarBook.Application.Mediator.Commands.CommentCommands
{
	public class RemoveCommentCommand : IRequest
	{
		public Guid Id { get; set; }

        public RemoveCommentCommand(Guid id)
        {
            Id = id;
        }
    }
}

