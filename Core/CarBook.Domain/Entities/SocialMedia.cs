using System;
using CarBook.Domain.Common;

namespace CarBook.Domain.Entities
{
	public class SocialMedia : BaseEntity
	{
		public string Name { get; set; }
		public string Url { get; set; }
		public string IconUrl { get; set; }
	}
}

