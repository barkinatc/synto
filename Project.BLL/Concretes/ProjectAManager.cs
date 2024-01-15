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
    public class ProjectAManager:BaseManager<ProjectA>,IProjectAManager
    {
        IProjectARepositoryDal _proRep;
        public ProjectAManager(IProjectARepositoryDal proRep):base(proRep) 
        {
            _proRep = proRep;
        }
    }
}
