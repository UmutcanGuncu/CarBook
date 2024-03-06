using System;
using Carbook.Persistence.Context;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Carbook.Persistence.Repositories
{
    public class CommentRepository : ICommentRepository
    {
        private readonly CarbookContext _context;

        public CommentRepository(CarbookContext context)
        {
            _context = context;
        }

        public async Task<List<Comment>> GetCommentByBlogId(Guid blogId)
        {
            var values = await _context.Comments.Where(x => x.BlogId == blogId).ToListAsync();
            return values;
        }
    }
}

