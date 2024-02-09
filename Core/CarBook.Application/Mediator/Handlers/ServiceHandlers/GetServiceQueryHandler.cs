using System;
using CarBook.Application.Interfaces;
using CarBook.Application.Mediator.Queries.ServiceQueries;
using CarBook.Application.Mediator.Results.ServiceResults;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Mediator.Handlers.ServiceHandlers
{
    public class GetServiceQueryHandler : IRequestHandler<GetServiceQuery, List<GetServiceQueryResult>>
    {
        private readonly IRepository<Services> _repository;

        public GetServiceQueryHandler(IRepository<Services> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetServiceQueryResult>> Handle(GetServiceQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetServiceQueryResult
            {
                Id = x.Id,
                Description = x.Description,
                IconUrl = x.IconUrl,
                Title = x.Title
            }).ToList();
        }
    }
}

