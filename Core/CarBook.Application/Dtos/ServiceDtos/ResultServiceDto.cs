using System;
namespace CarBook.Application.Dtos.ServiceDtos
{
	public class ResultServiceDto
	{
        public Guid id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string iconUrl { get; set; }
    }
}

