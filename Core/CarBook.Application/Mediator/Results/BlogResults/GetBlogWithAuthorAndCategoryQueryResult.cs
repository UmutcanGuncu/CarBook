using System;
namespace CarBook.Application.Mediator.Results.BlogResults
{
	public class GetBlogWithAuthorAndCategoryQueryResult
	{
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string CoverImageUrl { get; set; } //kapak fotoğrafı Url
        public DateTime CreatedDate { get; set; }
        public Guid AuthorId { get; set; }
        public string AuthorName { get; set; }
        public Guid CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}

