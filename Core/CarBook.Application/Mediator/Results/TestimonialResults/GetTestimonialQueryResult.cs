using System;
namespace CarBook.Application.Mediator.Results.TestimonialResults
{
	public class GetTestimonialQueryResult
	{
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Comment { get; set; }
        public string ImageUrl { get; set; }
    }
}

