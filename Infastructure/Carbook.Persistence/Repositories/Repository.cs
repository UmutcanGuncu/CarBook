﻿using System;
using Carbook.Persistence.Context;
using CarBook.Application.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Carbook.Persistence.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly CarbookContext _context;

        public Repository(CarbookContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(T entity)
        {
           _context.Set<T>().Add(entity);
           await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T?> GetByIdAsync(Guid id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task UpdateAsync(T entity)
        {
             _context.Set<T>().Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}

