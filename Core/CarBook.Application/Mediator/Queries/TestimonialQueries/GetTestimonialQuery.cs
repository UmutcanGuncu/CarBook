using System;
using CarBook.Application.Mediator.Results.TestimonialResults;
using MediatR;

namespace CarBook.Application.Mediator.Queries.TestimonialQueries
{
	public class GetTestimonialQuery : IRequest<List<GetTestimonialQueryResult>>
	{
		
	}
}

