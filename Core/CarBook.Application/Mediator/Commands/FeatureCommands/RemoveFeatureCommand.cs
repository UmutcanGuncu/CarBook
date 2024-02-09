using System;
using MediatR;

namespace CarBook.Application.Mediator.Commands.FeatureCommands
{
	public class RemoveFeatureCommand : IRequest
	{
        public RemoveFeatureCommand(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; set; }
	}
}

