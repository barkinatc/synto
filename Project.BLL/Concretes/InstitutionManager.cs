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
    public class InstitutionManager:BaseManager<Institution>,IInstitutionManager
    {
        IInstitutionRepositoryDal _institutionRep;
        public InstitutionManager(IInstitutionRepositoryDal institutionRep) :base(institutionRep) 
        {
            _institutionRep = institutionRep;
        }
    }
}
