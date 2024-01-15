using Microsoft.Build.Evaluation;

namespace synto.Areas.Admin.Models
{
    public class MissionPageVM
    {
        public List<AdminPageVM> Pages { get; set; }

        public List<MissionVM> Missions { get; set; }
        
    }
}
