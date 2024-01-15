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
    public class SubCategoryManager:BaseManager<SubCategory>,ISubCategoryManager
    {
        ISubCategoryRepositoryDal _subCatRep;
        public SubCategoryManager(ISubCategoryRepositoryDal subCatRep):base(subCatRep) 
        {
            _subCatRep = subCatRep;
        }
    }
}
