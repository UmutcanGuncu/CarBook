using System;
using CarBook.Application.Interfaces;
using CarBook.Application.Mediator.Queries.FooterAdressQueries;
using CarBook.Application.Mediator.Results.FooterAdressResults;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Mediator.Handlers.FooterAdressHandlers
{
    public class GetFooterAdressByIdQueryHandler : IRequestHandler<GetFooterAdressByIdQuery, GetFooterAdressByIdQueryResult>
    {
        private readonly IRepository<FooterAdress> _repository;

        public GetFooterAdressByIdQueryHandler(IRepository<FooterAdress> repository)
        {
            _repository = repository;
        }

        public async Task<GetFooterAdressByIdQueryResult> Handle(GetFooterAdressByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            return new GetFooterAdressByIdQueryResult
            {
                Id = value.Id,
                Adress = value.Adress,
                Description = value.Description,
                Email = value.Email,
                Phone = value.Phone
            };
            
        }
    }
}

