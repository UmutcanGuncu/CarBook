using System;
using CarBook.Application.Interfaces;
using CarBook.Application.Mediator.Queries.FooterAdressQueries;
using CarBook.Application.Mediator.Results.FooterAdressResults;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Mediator.Handlers.FooterAdressHandlers
{
    public class GetFooterAdressQueryHandler : IRequestHandler<GetFooterAdressQuery, List<GetFooterAdressQueryResult>>
    {
        private readonly IRepository<FooterAdress> _repository;

        public GetFooterAdressQueryHandler(IRepository<FooterAdress> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetFooterAdressQueryResult>> Handle(GetFooterAdressQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetFooterAdressQueryResult
            {
                Id = x.Id,
                Adress = x.Adress,
                Description = x.Description,
                Email = x.Email,
                Phone = x.Phone
            }).ToList();
        }
    }
}

