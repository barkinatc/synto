using Project.ENTITIES.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class PageInstitution:BaseEntity,IEntity
    {
        public int? PageID { get; set; }
        public int?      InstitutionID { get; set; }

        //Relational prop

        public virtual Page  Page { get; set; }
        public virtual Institution    Institution { get; set; }
    }
}
