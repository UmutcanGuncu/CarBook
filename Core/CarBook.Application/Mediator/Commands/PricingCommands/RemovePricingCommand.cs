using System;
using MediatR;

namespace CarBook.Application.Mediator.Commands.PricingCommands
{
	public class RemovePricingCommand : IRequest
	{
		public Guid Id { get; set; }

        public RemovePricingCommand(Guid id)
        {
            Id = id;
        }
    }
}

