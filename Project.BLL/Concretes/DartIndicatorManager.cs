using Project.BLL.Abstract;
using Project.DAL.Abstract;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.DAL.Context;


namespace Project.BLL.Concretes
{
    public class DartIndicatorManager:BaseManager<DartIndicator>, IDartIndicatorManager
    {

        private readonly MyContext _context;

      
        IDartIndicatorRepositoryDal _dartRep;
        public DartIndicatorManager(IDartIndicatorRepositoryDal dartRep, MyContext context):base(dartRep) 
        {
            _dartRep = dartRep;
            _context = context;
        }

        public bool Exists(int? dartId, int? indicatorId)
        {
          return  _context.DartIndicators.Any(x=>x.DartID == dartId && x.IndicatorID == indicatorId);
        }
    }
}
