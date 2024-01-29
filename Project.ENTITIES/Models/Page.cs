using Project.ENTITIES.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Page:BaseEntity,IEntity
    {

       
        public int? CategoryID { get; set; }


        public string? EditorContent { get; set; }









        //relation prop



        public virtual Category? Category { get; set; }

       
        public virtual List<Mission>? Missions { get; set; }
        public virtual List<PageInstitution> PageInstitutions { get; set; }
        public virtual List<PageAppUser> PageAppUsers { get; set; }

    }
}
