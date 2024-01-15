namespace synto.Areas.Admin.Models
{
    public class AdminAssignMissionVM
    {
        public List<AdminInstitutionVM> InstitutionVMs { get; set; }
        public List<AdminPageVM> PageVMs { get; set; }
        public CreateMissionVM CreateMission { get; set; }

        public int? selectedDivID { get; set; }

        public AdminAssignMissionVM()
        {
            CreateMission = new CreateMissionVM();
        }

    }
}
