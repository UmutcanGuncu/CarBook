using System;
namespace CarBook.Application.Dtos.BlogDtos
{
	public class Result3BlogDto
	{
		public Guid id { get; set; }
		public string title { get; set; }
		public string coverImageUrl { get; set; }
		public string authorName { get; set; }
		public DateTime createdDate { get; set; }
	}
}

