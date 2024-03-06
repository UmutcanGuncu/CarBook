using System;
using CarBook.Domain.Common;

namespace CarBook.Domain.Entities
{
	public class Blog : BaseEntity
	{
		public string Title { get; set; }
		public string Description { get; set; }
        public string CoverImageUrl { get; set; } //kapak fotoğrafı Url
		public DateTime CreatedDate { get; set; }
        public Guid AuthorId { get; set; }
		public Author Author { get; set; }
		public Guid CategoryId { get; set; }
		public Category Category { get; set; }
		public List<TagCloud> TagClouds { get; set; }
		public List<Comment> Comments { get; set; }
	}
}

