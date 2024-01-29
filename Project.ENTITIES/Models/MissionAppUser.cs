using Project.ENTITIES.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class MissionAppUser:BaseEntity,IEntity
    {
        public int? MissionID { get; set; }
        public int? AppUserID { get; set; }

        //Relational prop

        public virtual  AppUser AppUser { get; set; }
        public virtual  Mission Mission { get; set; }
    }
}
