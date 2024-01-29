using Project.ENTITIES.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class CategoryRevizyon:BaseEntity,IEntity
    {
        public string? EditorContent { get; set; }

        public string? ModifiedBy { get; set; }
        public int? CategoryID { get; set; }

        //Relational 

        public virtual Category Category { get; set; }
    }
}
