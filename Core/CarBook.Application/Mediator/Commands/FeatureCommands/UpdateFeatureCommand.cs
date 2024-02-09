using System;
using MediatR;

namespace CarBook.Application.Mediator.Commands.FeatureCommands
{
	public class UpdateFeatureCommand : IRequest
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
	}
}

