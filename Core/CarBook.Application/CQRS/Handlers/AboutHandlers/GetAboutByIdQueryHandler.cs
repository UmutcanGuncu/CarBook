using System;
using CarBook.Application.CQRS.Queries.AboutQueries;
using CarBook.Application.CQRS.Results.AboutResults;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.CQRS.Handlers.AboutHandlers
{
	public class GetAboutByIdQueryHandler
	{
		private readonly IRepository<About> _repository;

        public GetAboutByIdQueryHandler(IRepository<About> repository)
        {
            _repository = repository;
        }
        public async Task <GetAboutByIdQueryResult> Handle(GetAboutByIdQuery query)
        {
            var values = await _repository.GetByIdAsync(query.Id);
            return new GetAboutByIdQueryResult
            {
                Id = values.Id,
                Description = values.Description,
                ImageUrl = values.ImageUrl,
                Title = values.Title

            };
        }
    }
}

