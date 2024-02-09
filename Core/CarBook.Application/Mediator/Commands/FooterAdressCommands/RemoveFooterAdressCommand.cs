using System;
using MediatR;

namespace CarBook.Application.Mediator.Commands.FooterAdressCommands
{
	public class RemoveFooterAdressCommand : IRequest
	{
		public Guid Id { get; set; }

        public RemoveFooterAdressCommand(Guid id)
        {
            Id = id;
        }
    }
}

