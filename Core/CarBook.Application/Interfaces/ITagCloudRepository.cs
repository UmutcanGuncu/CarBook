using System;
using CarBook.Domain.Entities;

namespace CarBook.Application.Interfaces
{
	public interface ITagCloudRepository
	{
		Task<List<TagCloud>> GetTagCloudsByBlogId(Guid blogId);
	}
}

