﻿using System;
using Microsoft.EntityFrameworkCore;
using RentACar.DataAccess.IRepository;
using RentACar.DataAccess.Models;

namespace RentACar.DataAccess.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly RentACarDBContext _context;
        private readonly DbSet<T> _dbSet;

        public Repository(RentACarDBContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public void Update(T entity)
        {
            _dbSet.Update(entity);
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}

