using System;
using CarBook.Application.CQRS.Results.AboutResults;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.CQRS.Handlers.AboutHandlers
{
	public class GetAboutQueryHandler
	{
		private readonly IRepository<About> _repository;

        public GetAboutQueryHandler(IRepository<About> repository)
        {
            _repository = repository;
        }
        public async Task <List<GetAboutQueryResult>> Handle()
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetAboutQueryResult
            {
                Id = x.Id,
                Description = x.Description,
                Title = x.Title,
                ImageUrl = x.ImageUrl

            }).ToList();
        }
    }
}

