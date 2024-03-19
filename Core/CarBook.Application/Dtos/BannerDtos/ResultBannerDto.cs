using System;
namespace CarBook.Application.Dtos.BannerDtos
{
	public class ResultBannerDto
	{
		public Guid id { get; set; }
		public string title { get; set; }
		public string description { get; set; }
		public string videoDescription { get; set; }
		public string videoUrl { get; set; }

    }
}

