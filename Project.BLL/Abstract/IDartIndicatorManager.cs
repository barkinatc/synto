using Project.DAL.Context;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.Abstract
{
    public interface IDartIndicatorManager:IManager<DartIndicator>
    {
        
        public bool Exists(int? dartId, int? indicatorId);
        
     }
}
