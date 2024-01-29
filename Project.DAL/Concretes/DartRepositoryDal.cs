using Project.DAL.Abstract;
using Project.DAL.Context;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Concretes
{
    public class DartRepositoryDal:BaseRepositoryDal<Dart>,IDartRepositoryDal
    {
        public DartRepositoryDal(MyContext db):base(db)
        {
            
        }
    }
}
