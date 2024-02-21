using System;
using MediatR;

namespace CarBook.Application.Mediator.Commands.AuthorCommands
{
	public class RemoveAuthorCommand : IRequest
	{
		public Guid Id { get; set; }

        public RemoveAuthorCommand(Guid id)
        {
            Id = id;
        }
    }
}

