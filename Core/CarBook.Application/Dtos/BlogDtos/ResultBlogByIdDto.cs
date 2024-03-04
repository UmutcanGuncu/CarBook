using System;
namespace CarBook.Application.Dtos.BlogDtos
{
	public class ResultBlogByIdDto
	{
        public Guid id { get; set; }
        public string title { get; set; }
        public string coverImageUrl { get; set; }
        public Guid authorId { get; set; }
        public string authorName { get; set; }
        public DateTime createdDate { get; set; }
        public string description { get; set; }

    }
}

