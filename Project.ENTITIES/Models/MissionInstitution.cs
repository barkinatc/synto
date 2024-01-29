using Project.ENTITIES.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class MissionInstitution:BaseEntity,IEntity
    {
        public int? MissionID { get; set; }
        public int? InstitutionID { get; set; }

        //Relational

        public virtual Institution Institution { get; set; }
        public virtual Mission Mission { get; set; }

    }
}
