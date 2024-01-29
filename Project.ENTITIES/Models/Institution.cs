using Project.ENTITIES.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Institution:BaseEntity,IEntity
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public int? DartID { get; set; }

        //Relational Properties 
        public virtual List<AppUser> AppUsers  { get; set; }
      
        public virtual List<PageInstitution> PageInstitutions { get; set; }
        public virtual List<MissionInstitution> MissionInstitutions { get; set; }
        public virtual List<Indicator> Indicators { get; set; }
        public virtual Dart Dart  { get; set; }
    }
}
