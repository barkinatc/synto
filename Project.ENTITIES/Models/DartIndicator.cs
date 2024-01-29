using Project.ENTITIES.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class DartIndicator:BaseEntity,IEntity
    {
        public int? DartID { get; set; }
        public int? IndicatorID { get; set; }


        //Relational

        public virtual Dart Dart { get; set; }
        public virtual Indicator Indicator { get; set; }
    }
}
