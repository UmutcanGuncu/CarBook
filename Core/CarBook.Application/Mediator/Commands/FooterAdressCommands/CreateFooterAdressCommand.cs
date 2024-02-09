using System;
using MediatR;

namespace CarBook.Application.Mediator.Commands.FooterAdressCommands
{
	public class CreateFooterAdressCommand : IRequest
	{
        public string Description { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}

