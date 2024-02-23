using System;
namespace CarBook.Application.Dtos.CarDtos
{
	public class ResultCarWithBrandsDto
	{
        public Guid id { get; set; }
        public Guid brandId { get; set; }
        public string brandName { get; set; }
        public string model { get; set; }
        public string coverImageUrl { get; set; }
        public string bigImageUrl { get; set; }
        public int km { get; set; }
        public string transmission { get; set; }
        public int seat { get; set; }
        public int luggage { get; set; }
        public int priceAmountDay { get; set; }
        public string fuel { get; set; }
    }
}

