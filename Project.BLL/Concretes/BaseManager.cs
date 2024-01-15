using Project.BLL.Abstract;
using Project.DAL.Abstract;
using Project.ENTITIES.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.Concretes
{
    public class BaseManager<T> : IManager<T> where T : class, IEntity
    {
        protected IRepositoryDal<T> _iRep;
        public BaseManager(IRepositoryDal<T> iRep)
        {
            _iRep = iRep;
        }       
        public void Add(T item)
        {
            _iRep.Add(item);

        }

        public bool Any(Expression<Func<T, bool>> exp)
        {
            return _iRep.Any(exp);
        }

        public void Delete(T item)
        {
            _iRep.Delete(item);
        }

        public void Destroy(T item)
        {
            _iRep.Destroy(item);
        }

        public T Find(int id)
        {
            return _iRep.Find(id);
        }

        public T FirstOrDefault(Expression<Func<T, bool>> exp)
        {
            return _iRep.FirstOrDefault(exp);
        }

        public List<T> GetActives()
        {
            return _iRep.GetActives();
        }

        public List<T> GetAll()
        {
            return _iRep.GetAll();
        }

        public List<T> GetFirstDatas(int number)
        {
            return _iRep.GetFirstDatas(number);
        }

        public List<T> GetLastDatas(int number)
        {
            return _iRep.GetLastDatas(number);
        }

        public List<T> GetModifieds()
        {
            return _iRep.GetModifieds();
        }

        public List<T> GetPassives()
        {
            return _iRep.GetPassives();
        }

        public IQueryable<X> Select<X>(Expression<Func<T, X>> exp)
        {
            return _iRep.Select(exp);
        }

        public object Select(Expression<Func<T, bool>> exp)
        {
            return _iRep.Select(exp);
        }

        public void Update(T item)
        {
            _iRep.Update(item);
        }

        public List<T> Where(Expression<Func<T, bool>> exp)
        {
            return _iRep.Where(exp);
        }
    }
}
