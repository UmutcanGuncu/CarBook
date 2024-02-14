﻿using System;
using CarBook.Application.Interfaces;
using CarBook.Application.Mediator.Commands.TestimonialCommands;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Mediator.Handlers.TestimonialHandlers
{
    public class UpdateTestimonialCommandHandler : IRequestHandler<UpdateTestimonialCommand>
    {
        private readonly IRepository<Testimonial> _repository;

        public UpdateTestimonialCommandHandler(IRepository<Testimonial> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateTestimonialCommand request, CancellationToken cancellationToken)
        {
            var value =await _repository.GetByIdAsync(request.Id);
            value.Comment = request.Comment;
            value.ImageUrl = request.ImageUrl;
            value.Name = request.Name;
            value.Title = request.Title;
            await _repository.UpdateAsync(value);
        }
    }
}

