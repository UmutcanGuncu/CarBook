﻿using System;
namespace CarBook.Application.Dtos.ContactDtos
{
	public class PostContactFormDto
	{
        public string Name { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public DateTime SendDate { get; set; }
    }
}

