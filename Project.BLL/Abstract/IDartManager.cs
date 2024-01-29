using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.Abstract
{
    public interface IDartManager:IManager<Dart>
    {
        public List<Dart> GetDartsWithInstitutions();

    }
}
