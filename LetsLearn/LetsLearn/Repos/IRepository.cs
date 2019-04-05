using LetsLearn.Data;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace LetsLearn.Repos
{
    public interface IRepository
    {
        void Create<T>(T entity)
            where T : BaseEntity;

        void Update<T>(T entity)
            where T : BaseEntity;

        void Delete<T>(T entity)
            where T : BaseEntity;

        Task<ICollection<T>> GetAll<T>()
            where T : BaseEntity;

        Task<ICollection<T>> Find<T>(Expression<Func<T,bool>> predicate)
            where T : BaseEntity;

        Task<T> GetById<T> (string Id)
            where T : BaseEntity;

        Task<T> GetByUserName<T>(string UserName)
            where T : User;

        void Save();
    }
}
