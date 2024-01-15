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

        public int? PageType { get; set; }
        public int? CategoryID { get; set; }

        public int? Order { get; set; }
        public string? PageUniqueCode { get; set; }

        public int? InstitutionID { get; set; }









        //relation prop


        public virtual Category? Category { get; set; }
        public virtual Institution Institution { get; set; }

        public virtual List<Content>? Contents { get; set; }
        public virtual List<Image>? Images { get; set; }
        public virtual List<Data>? Datas { get; set; }
        public virtual List<Mission>? Missions { get; set; }
    }
}
