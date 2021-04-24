using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Data.Infrastructure
{
    public interface IResponsitory<T> where T: class
    {
        //Marks an entity as new
        void Add(T entity);
        //Marks an entity as Modified
        void Update(T entity);
        //Marks an entity to be Removed
        void Delete(T entity);
        void Delete(int id);

        //Delete multi records
        void DeleteMulti(Expression<Func<T, bool>> where);
        //Get an entity by Id
        T GetSingleById(int id);
        T GetSingleByCondition(Expression<Func<T, bool>> expression, string[] includes = null);

        IEnumerable<T> GetMany(Expression<Func<T, bool>> where, string includes);

        IQueryable<T> GetAll(string[] includes = null);

        IQueryable<T> GetMulti(Expression<Func<T, bool>> predicate, string[] includes = null);
        IEnumerable<T> GetMultiPaging(Expression<Func<T, bool>> predicate, out int total, int index = 0, int size = 50, string[] includes = null);
        bool CheckContains(Expression<Func<T, bool>> predicare);
    }
}
