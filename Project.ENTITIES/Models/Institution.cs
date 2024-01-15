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

        //Relational Properties 
        public virtual List<Mission> Missions  { get; set; }
        public virtual List<AppUser> AppUsers  { get; set; }
        public virtual List<Page> Pages  { get; set; }
    }
}
