using System;
using MediatR;

namespace CarBook.Application.Mediator.Commands.TestimonialCommands
{
	public class RemoveTestimonialCommand : IRequest
	{
		public Guid Id { get; set; }

        public RemoveTestimonialCommand(Guid id)
        {
            Id = id;
        }
    }
}

