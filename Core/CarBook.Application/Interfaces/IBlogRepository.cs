using System;
using CarBook.Domain.Entities;

namespace CarBook.Application.Interfaces
{
	public interface IBlogRepository
	{
		Task<List<Blog>> GetLast3BlogListWithAuthorAndCategory();
		Task<List<Blog>> GetBlogListWithAuthorAndCategory();
		Task<Blog> GetBlogListWithAuthorAndCategoryById(Guid id);

    }
}

