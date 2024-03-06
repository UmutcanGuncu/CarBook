using System;
using System.ComponentModel;
using CarBook.Domain.Common;

namespace CarBook.Domain.Entities
{
	public class Comment : BaseEntity
	{
		public string Name { get; set; }
		public DateTime CreateDate { get; set; }
		public string Description { get; set; }
		[DefaultValue("user.png")]
		public string ImageUrl { get; set; }
		public Guid BlogId { get; set; }
		public Blog Blog { get; set; }
	}
}

