﻿using FoodOrder.DataLayer;
using FoodOrder.Models;
using FoodOrder.Services.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrder.Services.Repository
{
    public class KategoriyaRepository : IKategoriyaInterface
    {
        private readonly AppDbContext _dbContext;

        public KategoriyaRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<Kategoriya> AddKategoriya(Kategoriya kategoriya)
        {
            _dbContext.Kategoriyalar.Add(kategoriya);
            _dbContext.SaveChanges();
            return Task.FromResult(kategoriya);
        }

        public Task DeleteKategoriya(Guid id)
        {
            Kategoriya kategoriya = _dbContext.Kategoriyalar
                                 .FirstOrDefault(m => m.Id == id);
            _dbContext.Remove(kategoriya);
            _dbContext.SaveChanges();
            return Task.FromResult(0);
        }

        public Task<Kategoriya> GetKategoriya(Guid id)
        {
            var res = _dbContext.Kategoriyalar
                .Include(k => k.Mahsulotlar)
                .FirstOrDefault(k => k.Id == id);

            return Task.FromResult(res);
        }

        public Task<List<Kategoriya>> GetKategoriyalar()
            => _dbContext.Kategoriyalar.ToListAsync();

        public Task<Kategoriya> UpdateKategoriya(Kategoriya kategoriya)
        {
            _dbContext.Kategoriyalar.Update(kategoriya);
            _dbContext.SaveChanges();
            return Task.FromResult(kategoriya);
        }
    }
}
