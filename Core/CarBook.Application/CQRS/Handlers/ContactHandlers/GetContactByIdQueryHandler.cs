using System;
using CarBook.Application.CQRS.Queries.ContactQueries;
using CarBook.Application.CQRS.Results.ContactResults;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.CQRS.Handlers.ContactHandlers
{
	public class GetContactByIdQueryHandler
	{
		private readonly IRepository<Contact> _repository;

        public GetContactByIdQueryHandler(IRepository<Contact> repository)
        {
            _repository = repository;
        }
        public async Task<GetContactByIdQueryResult> Handle(GetContactByIdQuery query)
        {
            var value = await _repository.GetByIdAsync(query.Id);
            return new GetContactByIdQueryResult
            {
                Id = value.Id,
                Name = value.Name,
                Email = value.Email,
                Subject = value.Subject,
                Message = value.Message,
                SendDate = value.SendDate
            };
        }
    }
}

