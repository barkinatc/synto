using Project.ENTITIES.Enums;
using Project.ENTITIES.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Indicator:BaseEntity,IEntity
    {
        public string? Name { get; set; }
        public string? HedefeEtkisiYuzde { get; set; }
        public string? PlanDonemiBaslangicDegeri { get; set; }
        public string? Yirmi20 { get; set; }
        public string? Yirmi21 { get; set; }
        public string? Yirmi22 { get; set; }
        public string? Yirmi23 { get; set; }
        public string? Yirmi24 { get; set; }
        public string? IS { get; set; }
        public string? RS { get; set; }

        public IndicatorUnits   Unit { get; set; }

        public int? InstitutionID { get; set; }


        //Relational prop

        public virtual Institution Institution { get; set; }
        public virtual List<DartIndicator> DartIndicators { get; set; }

    }
}
