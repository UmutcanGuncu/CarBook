using System;
namespace CarBook.Application.Mediator.Results.BlogResults
{
	public class GetBlogByAuthorIdQueryResult
	{
        public Guid AuthorId { get; set; }
        public string AuthorName { get; set; }
        public string AuthorImageUrl { get; set; }
        public string AuthorDescription { get; set; }
    }
}

