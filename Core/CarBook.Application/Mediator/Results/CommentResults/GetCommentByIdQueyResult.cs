using System;
using System.ComponentModel;

namespace CarBook.Application.Mediator.Results.CommentResults
{
	public class GetCommentByIdQueyResult
	{
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public string Description { get; set; }
        [DefaultValue("user.png")]
        public string ImageUrl { get; set; }
        public Guid BlogId { get; set; }
    }
}

