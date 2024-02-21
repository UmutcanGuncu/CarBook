using System;
using Carbook.Persistence.Context;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Carbook.Persistence.Repositories
{
    public class BlogRepository : IBlogRepository
    {
        private readonly CarbookContext _context;

        public BlogRepository(CarbookContext context)
        {
            _context = context;
        }

        public async Task<List<Blog>> GetBlogListWithAuthorAndCategory()
        {
            var values = await _context.Blogs.Include(x => x.Author).Include(x => x.Category).ToListAsync();
            return values;
            
        }

        public async Task<Blog> GetBlogListWithAuthorAndCategoryById(Guid id)
        {
            var value = await _context.Blogs.Include(x => x.Author).Include(x => x.Category).FirstOrDefaultAsync(x=>x.Id == id);
            return value;
        }

        public async Task<List<Blog>> GetLast3BlogListWithAuthorAndCategory()
        {
            var values = await _context.Blogs.Include(x => x.Author).Include(x => x.Category).Take(3).OrderBy(x => x.CreatedDate).ToListAsync();
            return values;
        }
    }
}

