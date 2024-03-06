using System;
namespace CarBook.Application.Dtos.CommentDtos
{
	public class ResultBlogDetailCommentsDto
	{
		public Guid id { get; set; }
		public string name { get; set; }
		public DateTime createDate { get; set; }
		public string description { get; set; }
		public string imageUrl { get; set; }
	}
}

