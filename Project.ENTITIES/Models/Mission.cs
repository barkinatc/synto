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
        public string Subject { get; set; }


        public int? CategoryID { get; set; }
        //public int? AppUserID { get; set; }
        
        public int? PageID { get; set; }
        public int? DartID { get; set; }
        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        //Relational Properties


        public virtual Category Category { get; set; }
        public virtual Page Page { get; set; }
        public virtual List<MissionAppUser> MissionAppUsers { get; set; }
        public virtual List<MissionInstitution> MissionInstitutions { get; set; }

        public virtual Dart  Dart { get; set; }


        //public virtual List<MissionAppUser> MissionAppUsers { get; set; }
        //public virtual List<MissionInstitution> MissionInstitutions { get; set; }


    }
}
