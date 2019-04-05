using LetsLearn.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace LetsLearn.Repos
{
    public class Repository : IRepository
    {
        private readonly ManagementContext _context;

        public Repository(ManagementContext context)
        {
            _context = context;
        }

        public void Create<T>(T entity) where T : BaseEntity
        {
            _context.Set<T>().Add(entity);
        }

        public void Update<T>(T entity) where T : BaseEntity
        {
            _context.Set<T>().Update(entity);
        }

        public void Delete<T>(T entity) where T : BaseEntity
        {
            _context.Set<T>().Remove(entity);
        }

        public async Task<ICollection<T>> GetAll<T>() where T : BaseEntity
        {
            return await _context.Set<T>().ToListAsync();
        }


        public async Task<T> GetById<T>(string Id) where T : BaseEntity
        {
            return await _context.Set<T>().SingleOrDefaultAsync(p => p.Id == Id);
        }

        public async Task<T> GetByUserName<T>(string UserName) where T : User
        {
            return await _context.Set<T>().SingleOrDefaultAsync(p => p.UserName == UserName);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public async Task<ICollection<T>> Find<T>(Expression<Func<T, bool>> predicate) where T : BaseEntity
        {
            return await _context.Set<T>().Where(predicate).ToListAsync();
        }
    }
}
