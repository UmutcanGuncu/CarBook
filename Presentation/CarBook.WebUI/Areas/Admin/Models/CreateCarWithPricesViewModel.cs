using System;
using System.ComponentModel.DataAnnotations;

namespace CarBook.WebUI.Areas.Admin.Models
{
	public class CreateCarWithPricesViewModel
	{
	    public Guid BrandId { get; set; }
        [Required]
        public string Model { get; set; }
        public IFormFile CoverImage { get; set; }
        public IFormFile BigImage { get; set; }
        public string CoverImageUrl { get; set; }
        public string BigImageUrl { get; set; }
        [Required]
        public int Km { get; set; }
        [Required]
        public string Transmission { get; set; }
        [Required]
        public int Seat { get; set; }
        [Required]
        public int Luggage { get; set; }
        [Required]
        public string Fuel { get; set; }
        [Required]
        public int AmountHour { get; set; }
        [Required]
        public int AmountDay { get; set; }
        [Required]
        public int AmountWeek { get; set; }
        
    }
}


