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
    public class MissionManager:BaseManager<Mission>,IMissionManager
    {
        IMissionRepositoryDal _missionRep;
        public MissionManager(IMissionRepositoryDal missionRep):base(missionRep) 
        {
            _missionRep = missionRep;
        }
    }
}
