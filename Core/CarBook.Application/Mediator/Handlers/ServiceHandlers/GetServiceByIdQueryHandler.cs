using System;
using CarBook.Application.Interfaces;
using CarBook.Application.Mediator.Queries.ServiceQueries;
using CarBook.Application.Mediator.Results.ServiceResults;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Mediator.Handlers.ServiceHandlers
{
    public class GetServiceByIdQueryHandler : IRequestHandler<GetServiceByIdQuery, GetServiceByIdQueryResult>
    {
        private readonly IRepository<Services> _repository;

        public GetServiceByIdQueryHandler(IRepository<Services> repository)
        {
            _repository = repository;
        }

        public async Task<GetServiceByIdQueryResult> Handle(GetServiceByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            return new GetServiceByIdQueryResult
            {
                Id = value.Id,
                Description = value.Description,
                IconUrl = value.IconUrl,
                Title = value.Title
            };
        }
    }
}

