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
    public class DataManager:BaseManager<Data>,IDataManager
    {
        IDataRepositoryDal _dRep;
        public DataManager(IDataRepositoryDal dRep):base(dRep) 
        {
            _dRep = dRep;
        }
    }
}
