using System;
using CarBook.Domain.Common;

namespace CarBook.Domain.Entities
{
	public class Author : BaseEntity // Yazar Sınıfı
	{
		public string Name { get; set; }
		public string ImageUrl { get; set; }
		public string Description { get; set; }
		public List<Blog> Blogs { get; set; }
	}
}

