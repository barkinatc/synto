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
    public class ContentManager:BaseManager<Content>,IContentManager
    {
        IContentRepositoryDal _conRep;
        public ContentManager(IContentRepositoryDal conRep):base(conRep) 
        {
            _conRep = conRep;
            
        }
    }
}
