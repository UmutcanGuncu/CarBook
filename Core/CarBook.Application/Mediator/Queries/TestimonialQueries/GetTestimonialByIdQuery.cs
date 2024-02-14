using System;
using CarBook.Application.Mediator.Results.TestimonialResults;
using MediatR;

namespace CarBook.Application.Mediator.Queries.TestimonialQueries
{
	public class GetTestimonialByIdQuery : IRequest<GetTestimonialByIdQueryResult>
	{
		public Guid Id { get; set; }

        public GetTestimonialByIdQuery(Guid id)
        {
            Id = id;
        }
    }
}

