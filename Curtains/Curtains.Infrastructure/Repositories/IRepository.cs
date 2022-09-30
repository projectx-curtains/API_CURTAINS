using Curtains.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtains.Infrastructure.Repositories
{
    public interface IRepository<T> where T : BaseEntity
    {
        IEnumerable<T> GetAll();
        Task<T> GetById(int Id);
        void Insert(T entity);
        void Update(T entity);
        void Remove(T entity);
        void SaveChanges();
    }
}
