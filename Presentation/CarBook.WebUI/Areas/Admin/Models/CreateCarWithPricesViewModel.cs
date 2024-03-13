using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CarBook.WebUI.Areas.Admin.Models
{
   
	public class CreateCarWithPricesViewModel 
	{
        public Guid BrandId { get; set; }
        public string CarModel { get; set; } //Model olarak isimlendirirsem hata yiyorum 
        public IFormFile CoverImage { get; set; }
        public IFormFile BigImage { get; set; }
        public int Km { get; set; }

        public string Transmission { get; set; }

        public int Seat { get; set; }

        public int Luggage { get; set; }

        public string Fuel { get; set; }

        public int AmountHour { get; set; }

        public int AmountDay { get; set; }

        public int AmountWeek { get; set; }

    }
}


