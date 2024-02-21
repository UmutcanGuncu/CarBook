using System;
using MediatR;

namespace CarBook.Application.Mediator.Commands.BlogCommands
{
	public class RemoveBlogCommand : IRequest
	{
		public Guid Id { get; set; }

        public RemoveBlogCommand(Guid id)
        {
            Id = id;
        }
    }
}

