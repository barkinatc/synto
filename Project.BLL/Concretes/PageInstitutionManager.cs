using Project.BLL.Abstract;
using Project.DAL.Abstract;
using Project.DAL.Context;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.Concretes
{
    public class PageInstitutionManager:BaseManager<PageInstitution>,IPageInstitutionManager
    {
        IPageInstitutionRepositoryDal _pageInsRep;
        private readonly MyContext _db;
        public PageInstitutionManager(IPageInstitutionRepositoryDal pageInsRep, MyContext db):base(pageInsRep) 
        {
            _pageInsRep = pageInsRep;
            _db = db;
        }

        public bool Exists(int? pageId, int? institutionId)
        {
            return _db.PageInstitutions.Any(x=>x.PageID == pageId && x.InstitutionID == institutionId);
        }
    }
}
