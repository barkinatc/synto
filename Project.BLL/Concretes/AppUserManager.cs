using Project.BLL.Abstract;
using Project.DAL.Abstract;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.Concretes
{
    public class AppUserManager : BaseManager<AppUser>, IAppUserManager
    {
        IAppUserRepositoryDal _appUserRepositoryDal;
        public AppUserManager(IAppUserRepositoryDal appUserRepositoryDal) : base(appUserRepositoryDal)
        {
            _appUserRepositoryDal = appUserRepositoryDal;
        }

    }
}
