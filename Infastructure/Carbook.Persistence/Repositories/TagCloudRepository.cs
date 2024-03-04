using System;
using Carbook.Persistence.Context;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Carbook.Persistence.Repositories
{
    public class TagCloudRepository : ITagCloudRepository
    {
        private readonly CarbookContext _carbookContext;

        public TagCloudRepository(CarbookContext carbookContext)
        {
            _carbookContext = carbookContext;
        }

        public Task<List<TagCloud>>GetTagCloudsByBlogId(Guid blogId)
        {
            var values =  _carbookContext.TagClouds.Where(x=>x.BlogId == blogId).ToListAsync();
            return values;
        }
    }
}

