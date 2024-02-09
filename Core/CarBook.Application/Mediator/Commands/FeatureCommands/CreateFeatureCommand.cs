using System;
using MediatR;

namespace CarBook.Application.Mediator.Commands.FeatureCommands
{
	public class CreateFeatureCommand : IRequest
	{
		public string Name { get; set; }
	}
}

