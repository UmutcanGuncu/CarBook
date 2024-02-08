using System;
using CarBook.Application.CQRS.Queries.CategoryQueries;
using CarBook.Application.CQRS.Results.CategoryResults;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.CQRS.Handlers.CategoryHandlers
{
	public class GetCategoryByIdQueryHandler
	{
		private readonly IRepository<Category> _repository;

        public GetCategoryByIdQueryHandler(IRepository<Category> repository)
        {
            _repository = repository;
        }
        public async Task<GetCategoryByIdQueryResult> Handle(GetCategoryByIdQuery query)
        {
            var value = await _repository.GetByIdAsync(query.Id);
            return new GetCategoryByIdQueryResult
            {
                Id = value.Id,
                Name = value.Name
            };
        }
    }
}

