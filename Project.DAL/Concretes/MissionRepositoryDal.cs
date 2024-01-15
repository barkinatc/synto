using Microsoft.EntityFrameworkCore;
using Project.DAL.Abstract;
using Project.DAL.Context;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Concretes
{
    public class MissionRepositoryDal:BaseRepositoryDal<Mission>, IMissionRepositoryDal
    {
        public MissionRepositoryDal(MyContext db):base(db) 
        {
            
        }
        
    }
}
