using Microsoft.CodeAnalysis.CSharp.Syntax;
using MyCvProject.Context;
using System.Collections.Generic;
using System.Linq;

namespace MyCvProject.Repositories
{
    public class GenericRepository<T> where T : class, new()
    {
        private readonly AppDbContext dbContext;

        public GenericRepository(AppDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public List<T> TGetAllList()
        {
            return dbContext.Set<T>().ToList();
        }

        public T TGetId(int id)
        {
            return dbContext.Set<T>().Find(id);
        }

        public void TAdd(T t)
        {
            dbContext.Set<T>().Add(t);
            dbContext.SaveChanges();
        }
        public void TDelete(T t)
        {
            dbContext.Set<T>().Remove(t);
            dbContext.SaveChanges();
        }

        public void TUpdate(T t)
        {
            dbContext.Set<T>().Update(t);
            dbContext.SaveChanges();
        }
    }
}
