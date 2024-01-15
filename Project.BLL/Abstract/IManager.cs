using Project.ENTITIES.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.Abstract
{
    public interface IManager<T> where T : class, IEntity
    {
        List<T> GetAll();


        List<T> GetActives();

        List<T> GetPassives();

        List<T> GetModifieds();

        void Add(T item);



        void Update(T item);



        void Delete(T item);



        void Destroy(T item);

        //Linq

        List<T> Where(Expression<Func<T, bool>> exp);


        bool Any(Expression<Func<T, bool>> exp);

        T FirstOrDefault(Expression<Func<T, bool>> exp);

        IQueryable<X> Select<X>(Expression<Func<T, X>> exp);

        object Select(Expression<Func<T, bool>> exp);

        //Find Command

        T Find(int id);

        //Last Data

        List<T> GetLastDatas(int number);

        //FirstData

        List<T> GetFirstDatas(int number);
    }
}
