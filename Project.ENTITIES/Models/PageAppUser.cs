using Project.ENTITIES.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class PageAppUser:BaseEntity,IEntity
    {
        public int? PageID { get; set; }
        public int? AppUserID { get; set; }

        //Relational prop

        public virtual Page Page { get; set; }
        public virtual AppUser AppUser { get; set; }
    }
}
