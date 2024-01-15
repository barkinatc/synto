namespace synto.Areas.Admin.Models
{
    public class MissionVM
    {
        public int ID { get; set; }
        public int? InstitutionID { get; set; }
        public int? PageID { get; set; }

        public int? CategoryID { get; set; }
        public string? CategoryName { get; set; }
        public int? PageType { get; set; }
        public int? PageOrder { get; set; }

    }
}
