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
    public class PageAppUserManager:BaseManager<PageAppUser>,IPageAppUserManager
    {
        IPageAppUserRepositoryDal __pageAppRep;
        public PageAppUserManager(IPageAppUserRepositoryDal pageAppRep):base(pageAppRep) 
        {
            __pageAppRep = pageAppRep;
        }
    }
}
