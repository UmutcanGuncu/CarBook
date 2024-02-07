﻿using System;
namespace CarBook.Application.CQRS.Results.AboutResults
{
	public class GetAboutByIdQueryResult
	{
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}

