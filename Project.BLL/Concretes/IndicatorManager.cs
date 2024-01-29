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
    public class IndicatorManager:BaseManager<Indicator>,IIndicatorManager
    {
        IIndicatorRepositoryDal _iRep;
        public IndicatorManager(IIndicatorRepositoryDal iRep):base(iRep) 
        {
            _iRep = iRep;
        }
    }
}
