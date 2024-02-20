using System;
namespace CarBook.Application.Dtos.CarDtos
{
	public class ResultFiveCarWithBrandsDto
	{
        public Guid id { get; set; }
        public Guid brandId { get; set; }
        public string brandName { get; set; }
        public string model { get; set; }
        public string coverImageUrl { get; set; }
    }
}

