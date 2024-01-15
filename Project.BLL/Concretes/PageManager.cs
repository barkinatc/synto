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
    public class PageManager:BaseManager<Page>,IPageManager
    {
        IPageRepositoryDal _pageRep;
        public PageManager(IPageRepositoryDal pageRep):base(pageRep) 
        {
            _pageRep = pageRep;
        }
    }
}
