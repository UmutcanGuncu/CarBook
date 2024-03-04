using System;
namespace CarBook.Application.Dtos.AuthorDtos
{
	public class ResultAuthorDto
    {
		public Guid authorId { get; set; }
		public string authorName { get; set; }
		public string authorImageUrl { get; set; }
		public string authorDescription { get; set; }
	}
}

