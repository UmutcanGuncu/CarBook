using System;
using CarBook.Domain.Common;

namespace CarBook.Domain.Entities
{
	public class TagCloud : BaseEntity
	{
		public string Title { get; set; }
		public Guid BlogId { get; set; }
		public Blog Blog { get; set; }
	}
}

