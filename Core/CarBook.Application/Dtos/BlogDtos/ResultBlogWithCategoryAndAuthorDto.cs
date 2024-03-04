using System;
namespace CarBook.Application.Dtos.BlogDtos
{
	public class ResultBlogWithCategoryAndAuthorDto
	{
		public Guid id { get; set; }
		public string title { get; set; }
		public string description { get; set; }
		public string coverImageUrl { get; set; }
		public DateTime createdDate { get; set; }
		public Guid authorId { get; set; }
		public string authorName { get; set; }
		public Guid categoryId { get; set; }
		public string categoryName { get; set; }
    }
}

