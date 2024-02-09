using System;
using MediatR;

namespace CarBook.Application.Mediator.Commands.PricingCommands
{
	public class UpdatePricingCommand : IRequest
	{
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}

