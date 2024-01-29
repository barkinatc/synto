using Project.ENTITIES.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Dart:BaseEntity,IEntity
    {
        public string? Amac { get; set; }

        public string? Hedef { get; set; }
        public string? Riskler { get; set; }
        public string? MaliyetTahmini { get; set; }
        public string? Tespitler { get; set; }
        public string? Ihtiyaclar { get; set; }
        public string? FaaliyetVeProjeler { get; set; }
        public string? SorumluBirim { get; set; }
        public int? SorumluBirimID { get; set; }
        public int? ProjectID { get; set; }
        public int? AppUserID { get; set; }
        public Dart()
        {
            Institutions = new List<Institution>();
        }


        //Relational properties

        public virtual List<Institution> Institutions { get; set; }
        public virtual List<DartIndicator> DartIndicators { get; set; }
        public virtual List<Mission> Missions { get; set; }

        public virtual ProjectA Project { get; set; }


        public virtual AppUser AppUser { get; set; }



    }
}
