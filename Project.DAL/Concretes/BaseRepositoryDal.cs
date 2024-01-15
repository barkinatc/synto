using Project.DAL.Abstract;
using Project.DAL.Context;
using Project.ENTITIES.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Concretes
{
    public class BaseRepositoryDal<T> : IRepositoryDal<T> where T : class, IEntity
    {
        protected MyContext _db;

        public BaseRepositoryDal(MyContext db)
        {
           _db = db;
        }
        public void Add(T item)
        {
            _db.Set<T>().Add(item);
            _db.SaveChanges();
        }

        public bool Any(Expression<Func<T, bool>> exp)
        {
            return _db.Set<T>().Any(exp);
        }

        public void Delete(T item)
        {
            item.Status = ENTITIES.Enums.DataStatus.Deleted;
            item.DeletedDate = DateTime.Now;
            _db.SaveChanges();
        }

        public void Destroy(T item)
        {
            _db.Set<T>().Remove(item);
            _db.SaveChanges();
        }

        public T Find(int id)
        {
            return _db.Set<T>().Find(id);
        }

        public T FirstOrDefault(Expression<Func<T, bool>> exp)
        {
            return _db.Set<T>().FirstOrDefault(exp);
        }

        public List<T> GetActives()
        {
            return Where(x => x.Status != ENTITIES.Enums.DataStatus.Deleted);
        }

        public List<T> GetAll()
        {
            return _db.Set<T>().ToList();
        }

        public List<T> GetFirstDatas(int number)
        {
            return _db.Set<T>().OrderBy(x => x.CreatedDate).Take(number).ToList();
        }

        public List<T> GetLastDatas(int number)
        {
            return _db.Set<T>().OrderByDescending(x => x.CreatedDate).Take(number).ToList();

        }

        public List<T> GetModifieds()
        {
            return Where(x => x.Status == ENTITIES.Enums.DataStatus.Modified);
        }

        public List<T> GetPassives()
        {
            return Where(x => x.Status == ENTITIES.Enums.DataStatus.Deleted);
        }

        public IQueryable<X> Select<X>(Expression<Func<T, X>> exp)
        {
            return _db.Set<T>().Select(exp);
        }

        public object Select(Expression<Func<T, bool>> exp)
        {
            return _db.Set<T>().Select(exp).ToList();
        }

        public void Update(T item)
        {
            item.Status = ENTITIES.Enums.DataStatus.Modified;
            item.ModifiedDate = DateTime.Now;
            _db.Update(item);
            _db.SaveChanges();
        }

        public List<T> Where(Expression<Func<T, bool>> exp)
        {
            return _db.Set<T>().Where(exp).ToList();
        }
    }
}
