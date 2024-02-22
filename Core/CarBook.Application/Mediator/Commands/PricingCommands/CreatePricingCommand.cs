﻿using System;
using MediatR;

namespace CarBook.Application.Mediator.Commands.PricingCommands
{
	public class CreatePricingCommand : IRequest
    {
        public int AmountHour { get; set; }
        public int AmountDay { get; set; }
        public int AmountWeek { get; set; }
        public Guid CarId { get; set; }
    }
}

