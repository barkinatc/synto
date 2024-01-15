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
    public class AppUserRepositoryDal : BaseRepositoryDal<AppUser>, IAppUserRepositoryDal
    {
        public AppUserRepositoryDal(MyContext db) : base(db)
        {

        }
    }
}
