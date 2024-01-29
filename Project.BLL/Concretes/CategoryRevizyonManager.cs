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
    public class CategoryRevizyonManager:BaseManager<CategoryRevizyon>,ICategoryRevizyonManager
    {
        ICategoryRevizyonRepositoryDal _catRep;

        public CategoryRevizyonManager(ICategoryRevizyonRepositoryDal catRep):base(catRep) 
        {
            _catRep = catRep;
        }
    }
}
