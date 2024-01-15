using Project.ENTITIES.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Category:BaseEntity,IEntity
    {
        public string Name { get; set; }
        public string? Desciption { get; set; }
        public int? ParentID { get; set; }

        public int? ProjectAID { get; set; }

        //Relational Properties 
        public virtual List<SubCategory> SubCategories { get; set; }

        public virtual ProjectA ProjectA { get; set; }
        public virtual List<Page> Pages { get; set; }

        public virtual List<Mission> Missions { get; set; }


    }

}
