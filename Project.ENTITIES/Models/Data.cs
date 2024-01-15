using Project.ENTITIES.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Data:BaseEntity,IEntity
    {

        public string? Title { get; set; }

        public string? Content { get; set; }

        public int? PageID { get; set; }

        //Relational Properties 

        public virtual Page Page { get; set; }


    }
}
