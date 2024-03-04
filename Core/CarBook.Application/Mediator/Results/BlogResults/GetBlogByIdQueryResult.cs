using System;
namespace CarBook.Application.Mediator.Results.BlogResults
{
	public class GetBlogByIdQueryResult
	{
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string CoverImageUrl { get; set; } //kapak fotoğrafı Url
        public DateTime CreatedDate { get; set; }
        public Guid AuthorId { get; set; }
        public Guid CategoryId { get; set; }
        public string Description { get; set; }
    }
}

