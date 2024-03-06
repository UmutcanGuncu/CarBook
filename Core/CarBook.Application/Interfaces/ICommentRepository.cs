using System;
using CarBook.Domain.Entities;

namespace CarBook.Application.Interfaces
{
	public interface ICommentRepository
	{
		Task<List<Comment>> GetCommentByBlogId(Guid blogId);
	}
}

