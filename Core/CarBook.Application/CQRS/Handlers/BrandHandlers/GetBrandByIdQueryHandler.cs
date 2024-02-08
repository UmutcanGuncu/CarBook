using System;
using CarBook.Application.CQRS.Queries.BrandQuery;
using CarBook.Application.CQRS.Results.BrandResult;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.CQRS.Handlers.BrandHandlers
{
	public class GetBrandByIdQueryHandler
	{
		private readonly IRepository<Brand> _repository;

        public GetBrandByIdQueryHandler(IRepository<Brand> repository)
        {
            _repository = repository;
        }
        public async Task<GetBrandByIdQueryResult> Handle(GetBrandByIdQuery query)
        {
            var value = await _repository.GetByIdAsync(query.Id);
            return new GetBrandByIdQueryResult
            {
                Id = value.Id,
                Name = value.Name
            };
        }
    }
}

