﻿using System;
namespace CarBook.Application.CQRS.Results.AboutResults
{
	public class GetAboutQueryResult
	{
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}

