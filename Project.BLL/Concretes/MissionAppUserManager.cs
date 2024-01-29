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
    public class MissionAppUserManager:BaseManager<MissionAppUser>,IMissionAppUserManager
    {
        IMissionAppUserRepositoryDal _missionAppRep;
        public MissionAppUserManager(IMissionAppUserRepositoryDal missionAppRep):base(missionAppRep) 
        {
            _missionAppRep = missionAppRep;
        }
    }
}
