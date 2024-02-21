﻿using System;
using CarBook.Application.Interfaces;
using CarBook.Application.Mediator.Queries.AuthorQueris;
using CarBook.Application.Mediator.Results.AuthorResults;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Mediator.Handlers.AuthorHandlers
{
    public class GetAuthorByIdQueryHandler : IRequestHandler<GetAuthorByIdQuery, GetAuthorByIdQueryResult>
    {
        private readonly IRepository<Author> _repository;

        public GetAuthorByIdQueryHandler(IRepository<Author> repository)
        {
            _repository = repository;
        }

        public async Task<GetAuthorByIdQueryResult> Handle(GetAuthorByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            return new GetAuthorByIdQueryResult
            {
                Id = value.Id,
                Blogs = value.Blogs,
                Description = value.Description,
                ImageUrl = value.ImageUrl,
                Name = value.Name
            };
        }
    }
}

