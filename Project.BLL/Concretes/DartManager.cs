using Microsoft.EntityFrameworkCore;
using Project.BLL.Abstract;
using Project.DAL.Abstract;
using Project.DAL.Context;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.Concretes
{
    public class DartManager:BaseManager<Dart>,IDartManager
    {
        IDartRepositoryDal _dRep;
        private readonly MyContext _context;
        public DartManager(IDartRepositoryDal dRep,MyContext context):base(dRep) 
        {
            _dRep = dRep;
            _context = context;
        }

        public List<Dart> GetDartsWithInstitutions()
        {
            return _context.Dart.Include(x=>x.Institutions).ToList();
        }
    }
}
