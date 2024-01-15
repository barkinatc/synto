using Project.ENTITIES.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class SubCategory:BaseEntity,IEntity
    {
        public string SubCategoryName { get; set; }

        public int? CategoryID { get; set; }

        //Relational prop

        public virtual Category Category { get; set; }
    }
}
