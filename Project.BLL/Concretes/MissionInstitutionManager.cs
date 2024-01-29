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
    public class MissionInstitutionManager:BaseManager<MissionInstitution>,IMissionInstitutionManager
    {
        IMissionInstitutionRepositoryDal _missionRep;
        public MissionInstitutionManager(IMissionInstitutionRepositoryDal missionRep):base(missionRep) 
        {
            _missionRep = missionRep;
        }
    }
}
