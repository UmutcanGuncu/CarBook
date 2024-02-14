using System;
using MediatR;

namespace CarBook.Application.Mediator.Commands.TestimonialCommands
{
	public class CreateTestimonialCommand : IRequest
    { 
        public string Name { get; set; }
        public string Title { get; set; }
        public string Comment { get; set; }
        public string ImageUrl { get; set; }
    }
}

