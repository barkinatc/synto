using Project.ENTITIES.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Mission:BaseEntity,IEntity
    {

        //public int? AppUserID { get; set; }
        public string MissionName { get; set; }

        public int? InstitutionID { get; set; }

        public int? CategoryID { get; set; }
        public int? PageID { get; set; }


        //Relational Properties

        public virtual Institution Institution { get; set; }
        public virtual Category Category { get; set; }
        public virtual Page Page { get; set; }

    }
}
