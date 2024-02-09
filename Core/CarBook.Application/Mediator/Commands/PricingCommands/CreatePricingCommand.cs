using System;
using MediatR;

namespace CarBook.Application.Mediator.Commands.PricingCommands
{
	public class CreatePricingCommand : IRequest
    { 
        public string Name { get; set; }
    }
}

