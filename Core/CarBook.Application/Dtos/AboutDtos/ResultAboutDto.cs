using System;
namespace CarBook.Application.Dtos.AboutDtos
{
	public class ResultAboutDto
	{
		public Guid id { get; set; }
		public string title { get; set; }
		public string description { get; set; }
		public string imageUrl { get; set; }
	}
}

