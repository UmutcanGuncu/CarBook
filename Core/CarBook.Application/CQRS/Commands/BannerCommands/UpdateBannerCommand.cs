﻿using System;
namespace CarBook.Application.CQRS.Commands.BannerCommands
{
	public class UpdateBannerCommand
	{
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string VideoDescription { get; set; }
        public string VideoUrl { get; set; }
    }
}

