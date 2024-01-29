using Project.ENTITIES.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class ProjectA:BaseEntity,IEntity
    {
        public string? Name { get; set; }

        //Relational prop

        public virtual List<Category> Categories { get; set; }
        public virtual List<Dart> Darts { get; set; }

    }
}
